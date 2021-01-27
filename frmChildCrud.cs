using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public static int guardian_id;

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

        /* Loads all guardians for a single child
         * and populates them in the datagridview.
         * INPUT: child
         * OUTPUT: list of guardians to datagridview.
         */
        private void LoadGuardiansForChild(Child child_in)
        {
            dgvGuardians.Rows.Clear();

            List<Guardian> guardians = SqliteDataAccess.GetGuardiansByChild(child_in);

            foreach (Guardian g in guardians)
            {
                dgvGuardians.Rows.Add(g.id, g.LastName, g.FirstName, g.PhoneNumber, g.EmailAddress);
            }
        }

        // Close the form without saving changes to the child.
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

        /* Adds an existing guardian to the child, if that guardian is not already assigned
         * to the child. The existing guardians are in the drop down list immediately
         * to the right of the button. First choose one, then click this button.
         * INPUTS: Guardian from the dropdown list
         * OUTPUTS: Updated list of authorized guardians for the child.
         */
        private void btnAddExistingGuardian_Click(object sender, EventArgs e)
        {
            int iOctomomCheck;

            //If the user did not select a guardian from the drop-down list.
            if(cbExistingGuardians.Text == "Choose a guardian to add to this child")
            {
                MessageBox.Show("Please select an existing guardian.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

            //The combobox is bound to a list of guardians, so we can just grab
            // the individual guardian object.
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

        /* Open a new form to create new guardians.
         * INPUTS: none
         * OUTPUTS: none
         */
        private void btnNewGuardian_Click(object sender, EventArgs e)
        {
            guardian_id = -1; //ENSURE!!!!

            ShowGuardianCrudForm();
        }

        /* Open a new form to update new guardians.
         * INPUTS: none
         * OUTPUTS: none
         */
        private void btnEditGuardian_Click(object sender, EventArgs e)
        {
            /* Get the guardian's database ID which is secretly hidden
             * in the datagrid view at column 0. Since value is an
             * Object, cast it to Int because that's what we know it is.
             */
            guardian_id = (int)dgvGuardians.CurrentRow.Cells[0].Value;

            ShowGuardianCrudForm();
        }

        /* Single function to show guardian crud form
         * as both the 'new' and the 'update' buttons need it,
         * the only difference is passing guardian_id.
         */
        private void ShowGuardianCrudForm()
        {
            Form frmGCrud = new frmGuardianCrud();
            frmGCrud.FormClosed += new FormClosedEventHandler(GCrudFormClosed);
            frmGCrud.Show();
            Hide();
        }

        //Show this admin screen after the child crud form is closed.
        private void GCrudFormClosed(object sender, FormClosedEventArgs e)
        {
            //This TOTALLY works!!!
            Guardian gFromGCrudForm = new Guardian();
            gFromGCrudForm = frmGuardianCrud.guardian;

            //We added a new guardian.
            //TODO: TEST
            if(gFromGCrudForm.id == 0)
            {
                Guardian gToAddToChild = new Guardian();
                gToAddToChild = SqliteDataAccess.GetGuardianByPin(gFromGCrudForm.PinNumber);
                SqliteDataAccess.AddNewGuardianToChild(child, gToAddToChild);
            }

            LoadGuardiansForChild(child);
            Show();
        }

        /* Irrevocably deletes a guardian and all attendence data
         * for that guardian out of the database.
         * INPUT: guardian
         * OUTPUT: void
         */
        private void btnDeleteGuardian_Click(object sender, EventArgs e)
        {
            /* Get the guardian's database ID which is secretly hidden
             * in the datagrid view at column 0. Since value is an
             * Object, cast it to Int because that's what we know it is.
             */
            guardian_id = (int)dgvGuardians.CurrentRow.Cells[0].Value;

            DialogResult dr = MessageBox.Show(">>WARNING!! Deleting the guardian will delete all attendence records associated with the guardian for all children.\n\rYOU CANNOT RECOVER OR UNDO THIS OPERATION.\n\rTHIS IS YOUR FINAL WARNING.\n\rDo you wish to continue?","Great Home Childcare",MessageBoxButtons.YesNoCancel,MessageBoxIcon.None);

            if(dr == DialogResult.Yes)
            {
                Guardian guardian = new Guardian(); //does not need to be full object.
                guardian.id = guardian_id;

                //Delete all the attendence data of that guardian.
                SqliteDataAccess.DeleteAttendenceForGuardian(guardian);

                //Remove the guardian from the child.
                SqliteDataAccess.RemoveGuardianFromAllChildren(guardian);

                //So long, sweet prince.
                SqliteDataAccess.DeleteGuardian(guardian);
                
                MessageBox.Show("The guardian has been deleted.");
                LoadGuardiansForChild(child);
            }
            else
            {
                MessageBox.Show("Delete canceled, no changes have been made.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        /* Saves a new child to the DB
         * or updates an existing child.
         * INPUT: Data from form
         * OUTPUT: Data to SQL database.
         */
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Perform sanity check, ensure all data is filled except picture
            this.Validate();

            // Check to see if any control is in error.
            foreach (Control c in errorProvider1.ContainerControl.Controls)
            {
                if (errorProvider1.GetError(c) != "")
                {
                    MessageBox.Show("Child not saved due to errors on the form!", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }
            }

            // Ensure the child has at least one guardian. This should work...
            // TODO: Test
            if(dgvGuardians.Rows.Count < 1)
            {
                MessageBox.Show("The child has no guardians assigned. Please fix that and try again.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

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

            //TODO: test
            if(child.id > 0) //Should be all that's needed.....
            {
                SqliteDataAccess.UpdateChild(child);
                MessageBox.Show("Child updated successfully! Data saved!");
            }
            else
            {
                //TODO: write code to add child. >> bee-gee's "Stayin' alive" plays <<
                //TED
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
        
        //Ensures a gender was chosen.
        private void genderComboBox_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            if (cb.SelectedIndex < 0)
                { errorProvider1.SetError(cb, "Select an item."); }
            else
                { errorProvider1.SetError(cb, ""); }
        }

        /* Validation of DOB Date Time Picker does not really do any validation
         * other than check the basic, most probable case of the date is still today.
         * Yes, the Child can literally be born yesterday, and enrolled in daycare.
         */
        private void dOBMonthCalendar_Validating(object sender, CancelEventArgs e)
        {
            MonthCalendar mc = (MonthCalendar)sender;

            if (mc.SelectionStart == DateTime.Today)
                { errorProvider1.SetError(mc, "Please choose the DOB."); }
            else
                { errorProvider1.SetError(mc, ""); }
        }

    }
}
