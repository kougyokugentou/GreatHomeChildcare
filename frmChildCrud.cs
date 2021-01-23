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
    public partial class frmChildCrud : Form
    {
        const string DEFAULT_PIC_TAG = "DefaultPic";
        const string CUSTOM_PIC_TAG = "dickpic";

        //Global instance of the SqliteDataAccess object.
        SqliteDataAccess SqliteDataAccess = new SqliteDataAccess();

        enum Gender
        {
            Female = 0,
            Male = 1
        }

        public frmChildCrud()
        {
            InitializeComponent();
        }

        /* Event handler on form load.
         * Reads the child_id from the admin form if the update button
         * was selected on the admin form.
         * INPUTS: child_id from the admin form
         * OUTPUTS: void
         */
        private void frmChildCrud_Load(object sender, EventArgs e)
        {
            FillGenderComboBox();

            int child_id = frmAdminForm.child_id;

            //If the update button was selected.
            if (child_id > 0)
            {
                LoadChild(child_id);
            }
        }

        private void FillGenderComboBox()
        {
            genderComboBox.Items.Add(Gender.Female);
            genderComboBox.Items.Add(Gender.Male);
        }

        /* Load an existing child onto the form for update/delete operations.
         * INPUT: integer child_id
         * OUTPUT: data to screen
         */
        private void LoadChild(int child_id_in)
        {
            Child child = SqliteDataAccess.GetChildByID(child_id_in);
            Gender genderOut;

            // sanity check, though it shouldn't be needed...
            if (child == null)
                return;

            //Load the child data into the form.
            idNumericUpDown.Value = child.id;
            firstNameTextBox.Text = child.FirstName;
            lastNameTextBox.Text = child.LastName;
            raceTextBox.Text = child.race;
            
            //Load the gender combo box based from enum value.
            //ref: chuck costarella
            Enum.TryParse<Gender>(child.gender, out genderOut);
            genderComboBox.SelectedItem = genderOut;

            addressTextBox.Text = child.address;
            photoPictureBox.Image = (child.photo != null) ? ImageWrangler.ByteArrayToImage(child.photo) : Properties.Resources.child;
            LoadGuardiansForChild(child);
        }

        private void LoadGuardiansForChild(Child child_in)
        {
            dgvGuardians.Rows.Clear();

            List<Guardian> guardians = SqliteDataAccess.GetGuardiansByChild(child_in);

            foreach (Guardian g in guardians)
            {
                dgvGuardians.Rows.Add(g.id, g.LastName, g.FirstName, g.PhoneNumber, g.EmailAddress);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //TODO: Ted, find a better way to do this than I did.
        private void btnPhotoFromCam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("From cam");
        }

        private void btnPhotoFromDisk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("From disk");
        }

        private void btnAddGuardian_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add guardian");
        }

        private void btnEditGuardian_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit Guardian");
        }

        private void btnDeleteGuardian_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Guardian");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save and close");
        }
    }
}
