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
        //SqliteDataAccess SqliteDataAccess = new SqliteDataAccess();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form frm2 = new frmMainForm();
            frm2.FormClosed += new FormClosedEventHandler(MainFormClosed);

            btnCE_Click(this, EventArgs.Empty);

            frm2.Show();
            Hide();
        }

        private void MainFormClosed(object sender, FormClosedEventArgs e)
        {

            Show();

        }
    }
}
