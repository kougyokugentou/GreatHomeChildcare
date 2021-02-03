using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GreatHomeChildcare.Models;

//REF:
//https://stackoverflow.com/questions/9780800/what-event-is-raised-when-a-user-interacts-with-the-datetimepicker-control

namespace GreatHomeChildcare
{
    public partial class frmReports : Form
    {
        //globals for cheap access.
        SqliteDataAccess SqliteDataAccess = new SqliteDataAccess();
        List<Child> AllChildren = new List<Child>();

        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
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
        }

        //Refresh the datagrid view.
        private void RefreshReportDgv()
        {
            dgvReports.Rows.Clear();

            //First do the everyone case.
            if(cbChildPicker.Text == "Everyone")
            {
                
            }
            else //load an individual child
            {
                
            }
        }
    }
}
