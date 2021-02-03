using System;
using System.Windows.Forms;
using GreatHomeChildcare.Models;

//Refs
// https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.form.shown?redirectedfrom=MSDN&view=net-5.0
namespace GreatHomeChildcare
{
    public partial class frmPinEntry : Form
    {
        //Global instance of the SqliteDataAccess object.
        SqliteDataAccess SqliteDataAccess = new SqliteDataAccess();

        public static string strPin = String.Empty;

        public frmPinEntry()
        {
            InitializeComponent();
        }

        /* Event delegate to handle all the numerical buttons on the page.
         * INPUT object sender, eventargs e
         * OUTPUT: Stores pin in hidden variable strPin, while displaying * in the text box.
         */
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

        //Prevents typing in the pin number box.
        private void tbPinNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Don't allow typing in the control.
            e.Handled = true;
        }

        /*Clears the pin entry completely, 
         * resetting the hidden variable strPin,
         * clearing the text box,
         * and disabling the login button.
         */
        private void btnCE_Click(object sender, EventArgs e)
        {
            strPin = String.Empty;
            tbPinNumber.Text = String.Empty;
            btnLogin.Enabled = false;
        }

        // Deletes the last number entered into the pinpad.
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

        /* Implements login functionality. If the pin # is valid (present in Guardian table)
         * then it will instantiate a new object of Form2, and attach a form closed delegate to it.
         * Then, the program shows the new form. strPin is public global so the new form can grab it.
         * The program will then hide the pinpad form and clear the entry/pin value from memory.
         */
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form frm2 = new frmMainForm();
            frm2.FormClosed += new FormClosedEventHandler(MainFormClosed);

            if(IsValidLogin(strPin))
            {
                frm2.Show();
                Hide();
                btnCE_Click(this, EventArgs.Empty);
            }
        }

        /* valid login check to see if pin# exists in the db.
         * INPUT integer pin number
         * OUTPUT boolean true/false
         */
        private bool IsValidLogin(string pin_in)
        {
            return true;
            //TODO: Remove above return statement and implement after code testing.
            //Could possibly move guardian to global and pass guardian to frmMainForm.
            Guardian guardian = new Guardian();

            guardian = SqliteDataAccess.GetGuardianByPin(Int32.Parse(pin_in));

            if(guardian == null)
            {
                MessageBox.Show("Sorry, that is an invalid login.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                return false;
            }

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
         * The Shown event is only raised the first time a form is displayed; subsequently
         * minimizing, maximizing, restoring, hiding, showing, or invalidating and repainting
         * will not raise this event. Ref: Microsoft
         */
        private void frmPinEntry_Shown(object sender, EventArgs e)
        {
            Hide();

            int num_admins = 0;
            DialogResult dr;

            num_admins = SqliteDataAccess.GetNumAdmins();

            if (num_admins <= 0)
            {
                dr = MessageBox.Show("Program not setup yet. Setup now?", "Great Home Childcare", MessageBoxButtons.YesNo, MessageBoxIcon.None);

                // Open the form to add a new guardian.
                if (dr == DialogResult.Yes)
                {
                    Form frm2 = new frmGuardianCrud();
                    frm2.FormClosed += new FormClosedEventHandler(MainFormClosed);
                    frm2.Show();
                    Hide();
                }
                else //Show a message and close the application.
                {
                    MessageBox.Show("Come back when you are ready to setup the program!", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Close();
                }
            }
            else
            {
                Show();
            }
        }
    }
}
