using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using GreatHomeChildcare.Models;

//REF:
//https://stackoverflow.com/questions/9780800/what-event-is-raised-when-a-user-interacts-with-the-datetimepicker-control
//https://stackoverflow.com/questions/2884356/how-do-i-auto-size-columns-through-the-excel-interop-objects

namespace GreatHomeChildcare
{
    public partial class frmReports : Form
    {
        //globals for cheap access.
        SqliteDataAccess SqliteDataAccess = new SqliteDataAccess();
        List<Child> AllChildren = new List<Child>();
        const string UNIXEPOCH = "1970-01-01";
        const string DATE_TO_STRING = "yyyy-MM-dd";

        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            /* The columns are there for us in the designer view.
             * Realistically we won't need them as the dgv is
             * programatically bound to a data source.
             */
            dgvReports.Columns.Clear();

            //cannot select from a future date.
            this.dtpFrom.MaxDate = DateTime.Now;

            //Ensure the To date is not before the From date.
            this.dtpTo.MinDate = this.dtpFrom.Value;
            this.dtpTo.MaxDate = DateTime.Now;

            LoadFilterComboBox();
            RefreshReportDgv();
        }

        private void LoadFilterComboBox()
        {
            Child everyoneSelection = new Child();

            /* cheap hack since you can't add an item to
             * a combobox that has existing databinding.
             */
            everyoneSelection.id = 0;
            everyoneSelection.DisplayName = "Everyone";

            AllChildren = SqliteDataAccess.GetAllChildren();
            AllChildren.Insert(0, everyoneSelection);

            cbChildPicker.DataSource = AllChildren;
        }

        /* Updates the on-screen display datagridview
         * upon selecting a new child from the drop-down box.
         */        
        private void cbChildPicker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RefreshReportDgv();
        }

        //DTP shenanigans ref stackexchange
        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            //Update the to date, but not before the From date.
            dtpTo.MinDate = dtpFrom.Value;
        }

        private void dtpFrom_DropDown(object sender, EventArgs e)
        {
            dtpFrom.ValueChanged -= dtpFrom_ValueChanged;
        }

        private void dtpFrom_CloseUp(object sender, EventArgs e)
        {
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            dtpFrom_ValueChanged(sender, e);
            RefreshReportDgv();
        }

        private void dtpTo_CloseUp(object sender, EventArgs e)
        {
            RefreshReportDgv();
        }

        //Refresh the datagrid view.
        private void RefreshReportDgv()
        {
            dgvReports.DataSource = null;

            dgvReports.Rows.Clear();
            
            //First do the everyone case.
            if(cbChildPicker.Text == "Everyone")
            {
                List<ReportScreen> lstRs = new List<ReportScreen>();

                foreach (DateTime day in EachDay(dtpFrom.Value, dtpTo.Value))
                {
                    //Double loop here is the only way I can think about it.
                    foreach (Child child in AllChildren)
                    {
                        //Repeat of the code of an individual child.
                        ReportScreen rs = new ReportScreen();
                        rs = ReportChildDay(child, day);

                        if (rs != null)
                        {
                            //push older events to the bottom.
                            lstRs.Insert(0, rs);
                        }
                    }//foreach child
                }//foreach day

                //Load the datagrid.
                dgvReports.DataSource = lstRs;
            }// end everyone
            else //load an individual child
            {
                Child child = (Child)cbChildPicker.SelectedItem;
                List<ReportScreen> lstRs = new List<ReportScreen>();

                foreach (DateTime day in EachDay(dtpFrom.Value, dtpTo.Value))
                {
                    ReportScreen rs = new ReportScreen();
                    rs = ReportChildDay(child, day);

                    if(rs != null)
                    {
                        //push older events to the bottom.
                        lstRs.Insert(0, rs);
                    }
                }

                //Load the datagrid.
                dgvReports.DataSource = lstRs;
            } //end else individual child
        }

        /* Gets sign/in out data for a single child given a single day.
         * INPUT: child, day
         * OUTPUT: reportscreen datatype class.
         */
        private ReportScreen ReportChildDay(Child child, DateTime day)
        {
            ReportScreen rs = new ReportScreen();
            AttendenceSingleInOutData in_data = new AttendenceSingleInOutData();
            AttendenceSingleInOutData out_data = new AttendenceSingleInOutData();

            in_data = SqliteDataAccess.GetAttendenceByStatusForChildByDay(child, "in", day.ToString(DATE_TO_STRING));
            out_data = SqliteDataAccess.GetAttendenceByStatusForChildByDay(child, "out", day.ToString(DATE_TO_STRING));

            if (in_data == null)
                return null;

            rs.ChildName = $"{in_data.ChildLastName}, {in_data.ChildFirstName}";
            rs.in_time = DateTime.Parse(in_data.timestamp);
            rs.GuardianInName = $"{in_data.GuardianLastName}, {in_data.GuardianLastName}";

            if (out_data != null) //Student's been checked out, display that data.
            {
                rs.out_time = DateTime.Parse(out_data.timestamp);
                rs.GuardianOutName = $"{out_data.GuardianLastName}, {out_data.GuardianFirstName}";
            }
            else //Student has not been checked out yet.
            {
                rs.out_time = DateTime.Parse(UNIXEPOCH);
                rs.GuardianOutName = String.Empty;
            }

            if (rs.out_time != DateTime.Parse(UNIXEPOCH)) //check for null out_time.
            {
                TimeSpan duration = rs.out_time.Subtract(rs.in_time);
                rs.Duration = duration.ToString();
            }

            return rs;
        }

        //https://stackoverflow.com/questions/1847580/how-do-i-loop-through-a-date-range
        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }

        private void btnSavetoCSV_Click(object sender, EventArgs e)
        {
            //If nothing's shown on screen, there's nothing to save.
            if(dgvReports.Rows.Count < 1)
            {
                MessageBox.Show("There are no reports for that time frame. Choose another time frame and try again.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

            //Build the default filename
            saveFileDialogReport.FileName = DateTime.Now.ToString("yy.MM.dd") + "-report.csv";

            if (saveFileDialogReport.ShowDialog() == DialogResult.OK
            && saveFileDialogReport.FileName != "")
            {
                string filename = saveFileDialogReport.FileName;
                SaveCSV(filename);
                MessageBox.Show("Report Saved", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        /* Function to save report data to a CSV file.
         * Seperated away from the button "save to csv" so
         * the "print" functionality can use it too.
         * INPUT: string filename
         * OUTPUT: csv file to disk.
         */
        private void SaveCSV(string filename)
        {
            List<ReportData> lstReport = new List<ReportData>();
            lstReport = GenerateReport();

            //Now with that monkey business out of the way
            //let's get on with actually saving the file.
            TextWriter textWriter = new StreamWriter(filename);
            CsvWriter csvWriter = new CsvWriter(textWriter);
            csvWriter.WriteRecords(lstReport);

            textWriter.Close();
        }

        private List<ReportData> GenerateReport()
        {
            List<ReportData> lstReport = new List<ReportData>();

            //First do the everyone case.
            if (cbChildPicker.Text == "Everyone")
            {
                /* This is basically the same code as ReportChildDay,
                 * but the query we are executing is different along with the datatype.
                 */
                foreach (DateTime day in EachDay(dtpFrom.Value, dtpTo.Value))
                {
                    List<ReportData> dayRd = new List<ReportData>();
                    dayRd = SqliteDataAccess.GetReportData(day.ToString(DATE_TO_STRING), null);
                    lstReport.AddRange(dayRd);
                }
            }
            else //an individual child was selected.
            {
                Child child = (Child)cbChildPicker.SelectedItem;

                foreach (DateTime day in EachDay(dtpFrom.Value, dtpTo.Value))
                {
                    List<ReportData> dayRd = new List<ReportData>();
                    dayRd = SqliteDataAccess.GetReportData(day.ToString(DATE_TO_STRING), child);
                    lstReport.AddRange(dayRd);
                }
            }
            return lstReport;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //If nothing's shown on screen, there's nothing to print.
            if (dgvReports.Rows.Count < 1)
            {
                MessageBox.Show("There are no reports for that time frame. Choose another time frame and try again.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

            //TODO: figure out a way to actually implement printing. It's one of the toolbox things.
            //1: Get temp environment variable
            DialogResult dr = PrintDialog.ShowDialog();

            if (dr == DialogResult.OK) //print
            {
                string filename = Environment.GetEnvironmentVariable("TEMP");
                filename += @"\GHCReport.csv";

                //Check to see if the file exists. If so, delete it.
                try
                {
                    if (File.Exists(filename))
                    {
                        File.Delete(filename);
                    }
                }
                catch
                {
                    MessageBox.Show("Please close Excel and try again.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }


                //Write the CSV.
                SaveCSV(filename);

                //Check again to see if writing the CSV was successful.
                //If not, show a message.
                if (!File.Exists(filename))
                {
                    MessageBox.Show("Could not save temporary file to print the report.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }

                //Cheaply print via Excel.
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Open(filename);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.Sheets[1];

                //ref: stack exchange
                worksheet.Columns.AutoFit();

                //print to default printer.
                worksheet.PrintOutEx(Type.Missing, Type.Missing, 
                    Type.Missing, Type.Missing, Type.Missing, 
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                // Cleanup Excel
                GC.Collect();
                GC.WaitForPendingFinalizers();
                Marshal.FinalReleaseComObject(worksheet);

                workbook.Close(false, Type.Missing, Type.Missing);
                Marshal.FinalReleaseComObject(workbook);

                excel.Quit();
                Marshal.FinalReleaseComObject(excel);
            }
        }
    }
}
