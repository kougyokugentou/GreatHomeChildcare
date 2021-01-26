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

namespace GreatHomeChildcare
{
    public partial class frmGuardianCrud : Form
    {
        //global variables
        SqliteDataAccess SqliteDataAccess = new SqliteDataAccess();
        Guardian guardian = new Guardian();
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
            FillIsAdminComboBox();

            int guardian_id = frmChildCrud.guardian_id;
            IsAdmin adminOut;

            if (guardian_id > 0)
            {
                guardian = SqliteDataAccess.GetGuardianById(guardian_id);
                idNumericUpDown.Value = guardian.id;
                lastNameTextBox.Text = guardian.LastName;
                firstNameTextBox.Text = guardian.FirstName;
                phoneNumberNumericUpDown.Value = guardian.PhoneNumber;
                emailAddressTextBox.Text = guardian.EmailAddress;
                strPin = guardian.PinNumber.ToString();

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

        //TODO: implement
        /* Save a new guardian or update 
         * an existing guardian.
         * INPUT: Data from form.
         * OUTPUT: data to sql database.
         */
        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save and close clicked");
        }
    }
}
