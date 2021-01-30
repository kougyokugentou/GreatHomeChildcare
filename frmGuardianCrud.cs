using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GreatHomeChildcare.Models;

namespace GreatHomeChildcare
{
    public partial class frmGuardianCrud : Form
    {
        //global variables
        SqliteDataAccess SqliteDataAccess = new SqliteDataAccess();
        public static Guardian guardian = new Guardian();
        public static string strPin = String.Empty;

        enum IsAdmin
        {
            No = 0,
            Yes = 1
        }

        public frmGuardianCrud()
        {
            InitializeComponent();
        }

        /* Load up the form with an existing guardian
         * if the "edit guardian" button was pressed
         * on the child crud form.
         */
        private void frmGuardianCrud_Load(object sender, EventArgs e)
        {
            int guardian_id = 0;
            IsAdmin adminOut;

            FillIsAdminComboBox();

            /* If it's the first time run of this program
             * then setup the initial admin user.
             */
            if(SqliteDataAccess.GetNumAdmins() <= 0)
            {
                isAdminComboBox.SelectedItem = IsAdmin.Yes;
                isAdminComboBox.Enabled = false;
                btnCancelClose.Enabled = false;
            }
            else
            {
                guardian_id = frmChildCrud.guardian_id;
            }

            if (guardian_id > 0)
            {
                guardian = SqliteDataAccess.GetGuardianById(guardian_id);
                idNumericUpDown.Value = guardian.id;
                lastNameTextBox.Text = guardian.LastName;
                firstNameTextBox.Text = guardian.FirstName;
                phoneNumberNumericUpDown.Value = guardian.PhoneNumber;
                emailAddressTextBox.Text = guardian.EmailAddress;
                strPin = guardian.PinNumber.ToString();
                tbPinNumber.Text = "****";

                //Load the isAdmin combo box based from enum value.
                //ref: chuck costarella
                Enum.TryParse<IsAdmin>(guardian.isAdmin.ToString(), out adminOut);
                isAdminComboBox.SelectedItem = adminOut;
            }
        }

        // Fill the IsAdmin combo box with our enum.
        private void FillIsAdminComboBox()
        {
            isAdminComboBox.Items.Add(IsAdmin.No);
            isAdminComboBox.Items.Add(IsAdmin.Yes);
            isAdminComboBox.SelectedItem = IsAdmin.No;
        }

        //Close the form without saving changes.
        private void btnCancelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* Save a new guardian or update 
         * an existing guardian.
         * INPUT: Data from form.
         * OUTPUT: data to sql database.
         */
        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            Guardian checkExistingGuardian = new Guardian();
            int num_admins;

            this.Validate();
            this.ValidateChildren();

            // Check to see if any control is in error.
            foreach (Control c in errorProvider1.ContainerControl.Controls)
            {
                if (errorProvider1.GetError(c) != "")
                {
                    MessageBox.Show("Guardian not saved due to errors on the form!", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }
            }

            // validate pin
            if(strPin.Length < 4)
            {
                MessageBox.Show("Please enter a 4-digit pin number.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

            checkExistingGuardian = SqliteDataAccess.GetGuardianByPin(Int32.Parse(strPin));

            //If this is a new guardian, check to see if that pin is in use.
            if(idNumericUpDown.Value == 0 && checkExistingGuardian != null)
            {
                MessageBox.Show("Please choose a different PIN number.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

            guardian.id = Int32.Parse(idNumericUpDown.Value.ToString());
            guardian.LastName = lastNameTextBox.Text;
            guardian.FirstName = firstNameTextBox.Text;
            guardian.PhoneNumber = long.Parse(phoneNumberNumericUpDown.Value.ToString());
            guardian.EmailAddress = emailAddressTextBox.Text;
            guardian.PinNumber = Int32.Parse(strPin);

            if(guardian.id == 0) // new guardian
            {
                SqliteDataAccess.InsertNewGuardian(guardian);
            }
            else
            {
                //Check to see if no admins will be left over.
                num_admins = SqliteDataAccess.GetNumAdmins();
                num_admins--;

                if ((IsAdmin)isAdminComboBox.SelectedItem == IsAdmin.No
                    && num_admins <= 0)
                {
                    MessageBox.Show("You are removing the last known admin, that would break this program.\n\rThe IsAdmin selection has changed to YES, please re-check the form entry then resubmit.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                    isAdminComboBox.SelectedItem = IsAdmin.Yes;
                    return;
                }

                SqliteDataAccess.UpdateGuardian(guardian);
            }

            Close();
        }

        // Basic input validation on a string given a textbox control
        // ensures only values a-z, with length two or greater.
        private void String_TextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!Regex.IsMatch(tb.Text, "[A-Za-z]{2,}"))
                errorProvider1.SetError(tb, "Enter a value a-z only of length two or longer.");
            else
                errorProvider1.SetError(tb, "");
        }

        /* Does not really check to see if it is a valid phone number
         * since the phone companies introduce new area codes all the damn time.
         * Only checks to see the most likely case that the user of the program
         * has left the phone number value as the default minimum value.
         */
        private void phoneNumberNumericUpDown_Validating(object sender, CancelEventArgs e)
        {
            if (phoneNumberNumericUpDown.Value == phoneNumberNumericUpDown.Minimum
            || phoneNumberNumericUpDown.Value == phoneNumberNumericUpDown.Maximum)
                { errorProvider1.SetError(phoneNumberNumericUpDown, "Type in a valid phone number"); }
            else
                { errorProvider1.SetError(phoneNumberNumericUpDown, ""); }
        }

        //Validates any given combobox to ensure an item is selected.
        private void isAdminComboBox_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            if (cb.SelectedIndex < 0)
                { errorProvider1.SetError(cb, "Select an item."); }
            else
                { errorProvider1.SetError(cb, ""); }
        }

        //validate a 4-digit pin number was entered.
        private void tbPinNumber_Validating(object sender, CancelEventArgs e)
        {
            if(tbPinNumber.TextLength != 4)
                { errorProvider1.SetError(tbPinNumber, "Please enter a 4-digit PIN."); }
            else
                { errorProvider1.SetError(tbPinNumber, ""); }
        }

        /* Checks to see if provided email address is valid
         * by matching against an email address regex i stole from the interweb.
         */
        private void emailAddressTextBox_Validating(object sender, CancelEventArgs e)
        {
            //email address regex
            //^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,5}$
            if (!Regex.IsMatch(emailAddressTextBox.Text, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,5}$"))
                errorProvider1.SetError(emailAddressTextBox, "Enter a valid email address: user@domain.com");
            else
                errorProvider1.SetError(emailAddressTextBox, "");
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
        }

        //Prevents typing in the pin number box.
        private void tbPinNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Don't allow typing in the control.
            e.Handled = true;
        }

        /*Clears the pin entry completely, 
         * resetting the hidden variable strPin,
         * and clearing the text box
         */
        private void btnCE_Click(object sender, EventArgs e)
        {
            strPin = String.Empty;
            tbPinNumber.Text = String.Empty;
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
        }
    }
}
