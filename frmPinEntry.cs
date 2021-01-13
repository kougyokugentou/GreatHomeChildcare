using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreatHomeChildcare
{
    public partial class frmPinEntry : Form
    {
        //Global instance of the SqliteDataAccess object.
        SqliteDataAccess SqliteDataAccess = new SqliteDataAccess();
        const string DEFAULT_PIC_TAG = "DefaultPic";
        const string CUSTOM_PIC_TAG = "dickpic";

        string strPin = String.Empty;

        public frmPinEntry()
        {
            InitializeComponent();
        }

        private void btnNumButton_Click(object sender, EventArgs e)
        {
            //Don't allow a PIN length longer than 4 digits.
            if (strPin.Length >= 4)
                return;

            //to the passed in sender source and cast it to a Button
            Button button = (Button)sender;
            strPin += button.Text;
            tbPinNumber.Text += button.Text;

            if (strPin.Length == 4)
                btnLogin.Enabled = true;
        }

        private void tbPinNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Don't allow typing in the control.
            e.Handled = true;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            strPin = String.Empty;
            tbPinNumber.Text = String.Empty;
            btnLogin.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //If there is nothing in the display, do not attempt
            //to remove any digits, or the program will crash.
            if (strPin.Length == 0)
                return;

            //Assign the text in the display using a substring
            //of whatever the text is, subtracting the length by 1.
            //This effectively 'strips' the last digit from the display string.
            tbPinNumber.Text = tbPinNumber.Text.Substring(0, tbPinNumber.Text.Length - 1);
            strPin = strPin.Substring(0, strPin.Length - 1);

            //disable login button
            btnLogin.Enabled = false;
        }

        //
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form frm2 = new frmMainForm();
            frm2.FormClosed += new FormClosedEventHandler(MainFormClosed);

            if(IsValidLogin(strPin))
            {
                btnCE_Click(this, EventArgs.Empty);

                frm2.Show();
                Hide();
            }
        }

        //TODO: implement valid login check.
        //do this after all the other bits of the program are written/tested.
        private bool IsValidLogin(string pin_in)
        {
            return true;
        }

        //Show the pin login screen after the main student login/out form is closed.
        private void MainFormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        /* Checks to see if this is the first-ever time the application has
         * run by querying number of rows in Guardian table.
         * If number of rows <= 0, we must setup an admin user in the guardian table.
         */
        private void frmPinEntry_Load(object sender, EventArgs e)
        {
            bool bIsFirstTime = false;
            DialogResult dr;

            bIsFirstTime = SqliteDataAccess.isFirstTimeRun();

            if(bIsFirstTime)
            {
                dr = MessageBox.Show("Program not setup yet. Setup now?", "Great Home Childcare", MessageBoxButtons.YesNo, MessageBoxIcon.None);

                //TODO: Open the form to add a new guardian.
                if (dr == DialogResult.Yes)
                    return;

                else //Show a message and close the application.
                {
                    MessageBox.Show("Come back when you are ready to setup the program!", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Close();
                }
            }
        }
    }
}
