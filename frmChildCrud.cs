using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        const int MAX_PIC_SIZE = 2147483647;

        //Global instance of the SqliteDataAccess object.
        SqliteDataAccess SqliteDataAccess = new SqliteDataAccess();
        Child child;
        int guardian_id;

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
            FillGuardiansComboBox();

            int child_id = frmAdminForm.child_id;

            //If the update button was selected.
            if (child_id > 0)
            {
                LoadChild(child_id);
            }
        }

        //Populate the gender combo box with our enum.
        private void FillGenderComboBox()
        {
            genderComboBox.Items.Add(Gender.Female);
            genderComboBox.Items.Add(Gender.Male);
        }

        /* Populate the existing guardian combobox
         * with a listing of all guardians in the DB
         * sorted by last name. Bind the guardian object
         * to the drop-down so it can be easily referenced upon click
         * of "add existing guardian".
         * INPUTS: void from program
         * OUTPUT: list of guardians from SQL db
         */
        private void FillGuardiansComboBox()
        {
            List<Guardian> guardians = new List<Guardian>();
            guardians = SqliteDataAccess.GetAllGuardians();

            cbExistingGuardians.DataSource = guardians;
            cbExistingGuardians.DisplayMember = "DisplayName";
            cbExistingGuardians.Text = "Choose a guardian to add to this child";
        }

        /* Load an existing child onto the form for update/delete operations.
         * INPUT: integer child_id
         * OUTPUT: data to screen
         */
        private void LoadChild(int child_id_in)
        {
            child = SqliteDataAccess.GetChildByID(child_id_in);
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

            dOBMonthCalendar.SelectionStart = DateTime.Parse(child.DOB);
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

        /* On click of the button, open a file picker dialog box
         * for the user to browse/choose a picture.
         * Once the user clicks OK, the _FileOK event below fires,
         * validates the input. If file is OK, then read the file from disk,
         * convert it into an Image, and save it to the student picture box.
         */
        private void btnPhotoFromDisk_Click(object sender, EventArgs e)
        {
            DialogResult dr = pic_openFileDialog.ShowDialog();
            byte[] pic_in;

            if (dr == DialogResult.OK)
            {
                try
                {
                    //Read picture
                    pic_in = File.ReadAllBytes(pic_openFileDialog.FileName);

                    //Check once again to make sure the picture's not too big...
                    if(pic_in.Length >= MAX_PIC_SIZE)
                    {
                        MessageBox.Show("The selected child's photo size is too large. Choose a smaller photo size or shrink the photo.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                        return;
                    }
                    Image dickPic = ImageWrangler.ByteArrayToImage(pic_in);

                    //Place in dicpic box
                    photoPictureBox.Image = dickPic;

                    //change tag of pic box to something else
                    photoPictureBox.Tag = CUSTOM_PIC_TAG;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to read selected file, try again.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }
            }
        }

        private void btnAddGuardian_Click(object sender, EventArgs e)
        {
            int iOctomomCheck;

            if(cbExistingGuardians.Text == "Choose a guardian to add to this child")
            {
                MessageBox.Show("Please select an existing guardian.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            
            Guardian newGuardian = (Guardian)cbExistingGuardians.SelectedItem;
            //Check to see if newGuardian is already a guardian of this child.
            foreach(DataGridViewRow row in dgvGuardians.Rows)
            {
                if((int)row.Cells[0].Value == newGuardian.id)
                {
                    MessageBox.Show("That guardian is already assigned to this child.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }
            }

            // Check for octomom.
            iOctomomCheck = SqliteDataAccess.CheckForOctomom(newGuardian);
            if(iOctomomCheck > 9) // SERIOUSLY, KEEP IT IN YOUR PANTS
            {
                MessageBox.Show("Sorry, a single guardian can't have more than 9 children.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

            // We are clear to add this guardian.
            SqliteDataAccess.AddNewGuardianToChild(child, newGuardian);
            LoadGuardiansForChild(child);
        }

        private void btnNewGuardian_Click(object sender, EventArgs e)
        {
            guardian_id = -1;
            MessageBox.Show("Add (create) New guardian");
        }

        private void btnEditGuardian_Click(object sender, EventArgs e)
        {
            /* Get the guardian's database ID which is secretly hidden
             * in the datagrid view at column 0. Since value is an
             * Object, cast it to Int because that's what we know it is.
             */
            guardian_id = (int)dgvGuardians.CurrentRow.Cells[0].Value;

            MessageBox.Show("Edit Guardian");
        }

        private void btnDeleteGuardian_Click(object sender, EventArgs e)
        {
            /* Get the guardian's database ID which is secretly hidden
             * in the datagrid view at column 0. Since value is an
             * Object, cast it to Int because that's what we know it is.
             */
            guardian_id = (int)dgvGuardians.CurrentRow.Cells[0].Value;

            MessageBox.Show("Delete Guardian");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save and close");
            return;

            //collect form and save to child object.
            child.id = (int)idNumericUpDown.Value;
            child.address = addressTextBox.Text;
            child.DOB = dOBMonthCalendar.SelectionStart.ToShortDateString();
            child.FirstName = firstNameTextBox.Text;
            child.gender = genderComboBox.Text;
            child.LastName = lastNameTextBox.Text;
            child.race = raceTextBox.Text;

            if (photoPictureBox.Tag.ToString() == DEFAULT_PIC_TAG)
                child.photo = null;
            else
                child.photo = ImageWrangler.ImageToByteArray(photoPictureBox.Image);

            if(child.id > 0) //Should be all that's needed.....
            {
                SqliteDataAccess.UpdateChild(child);
                MessageBox.Show("Child updated successfully! Data saved!");
            }
            else
            {
                //TODO: write code to add child. >> bee-gee's "Stayin' alive" plays <<
                /* PB&J
                 * Pop new window to add at least one guardian to the child, either existing or new.
                 * Validate guardian exist in db upon return to this form.
                 * if valid, then populate guardian table and update authorized_guardians
                 * LAST THING: InsertNewStudent(child);
                 */
            }
            Close();
        }

        /* Event that occurs when the user clicks Open in the file dialog box.
         * Check to see if the photo size is too large for the database.
         * If so, reject the file and inform the user.
         */
        private void pic_openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            byte[] dickpic;

            try
            {
                //Chunk file into bytes.
                //If file > MAX_PIC_SIZE bytes long, reject file.
                dickpic = File.ReadAllBytes(pic_openFileDialog.FileName);
                if (dickpic.Length >= MAX_PIC_SIZE) //THAT'S WHAT SHE SAID
                {
                    MessageBox.Show("The selected child's photo size is too large. Choose a smaller photo size or shrink the photo.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Unable to read selected file, try again.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
        }

    }
}
