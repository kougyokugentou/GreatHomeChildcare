using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GreatHomeChildcare.Models;

namespace GreatHomeChildcare
{
    public partial class frmMainForm : Form
    {
        //globals for cheap access.
        SqliteDataAccess SqliteDataAccess = new SqliteDataAccess();
        Guardian guardian = new Guardian();

        public frmMainForm()
        {
            InitializeComponent();
        }

        /* Event handler for form load.
         * Shows a button for each child that has been assigned to the guardian.
         */
        private void frmMainForm_Load(object sender, EventArgs e)
        {
            int child_count = 1; //for iteration

            int guardian_pin = Int32.Parse(frmPinEntry.strPin);
            guardian = SqliteDataAccess.GetGuardianByPin(guardian_pin);
            List<Child> children = SqliteDataAccess.GetChildrenByGuardian(guardian);

            //TODO: remove once valid login check is implemented
            if (guardian == null)
                return;

            //If the guardian is an admin user, enable the button for crud operations.
            if (guardian.isAdmin == 1)
            {
                btnAdmin.Visible = true;
                btnAdmin.Enabled = true;
            }

            //If the guardian has no children, show a message.
            if (children == null)
            {
                lblNoChildren.Visible = true;
                return;
            }

            //For each child, present a new button to sign the student in/out.
            //Max 9 children(!!) per guardian. We support Octomom!
            foreach(Child child in children)
            {
                //Make sure we don't break the program.
                if (child_count >= 10) //Keep it in your pants, man!!
                {
                    MessageBox.Show("Sorry, the program only supports 9 children per guardian.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;
                }

                Control controls = tableLayoutPanel1.Controls["panelChild" + child_count];
                controls.Visible = true;

                //Populate the newly shown button with the child's information
                PopulateButton(child, controls);
                child_count++;
            }
        }

        /* Populate a button with a child's information.
         * INPUT: child, panel (as a control)
         * OUTPUT: void to program, child information to button/gui.
         */
        private void PopulateButton(Child child_in, Control controls_in)
        {
            Control.ControlCollection nested_controls = controls_in.Controls;
            foreach(Control c in nested_controls)
            {
                if (c is PictureBox)
                {
                    PictureBox pb = (PictureBox)c;
                    pb.Image = child_in.photo == null ? Properties.Resources.child : ImageWrangler.ByteArrayToImage(child_in.photo);
                }

                //TODO: BUG: If the child is new and does not have sign in/out status, program crashes.
                //Fix: if studentStatus is null, set new var to "NONE YET", else set new var to actual status.

                if (c is Button)
                {
                    Button btn = (Button)c;
                    Attendance studentStatus = SqliteDataAccess.GetChildSignInOut(child_in);
                    string btnText = child_in.DisplayName + "\n\r"
                                   + "Status: Signed " + studentStatus.in_out.ToUpper() + "\n\r"
                                   + studentStatus.timestamp;

                    //shove the child into the Tag property which is a type of 'object' for later retrieval.
                    //see also: cheap hax
                    btn.Text = btnText;
                    btn.Tag = child_in;

                    UpdatePanelColor(btn.Parent, studentStatus.in_out);
                }
            } //foreach control
        }

        // Open the main administration form.
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form frmAdm = new frmAdminForm();
            frmAdm.FormClosed += new FormClosedEventHandler(AdminFormClosed);
            frmAdm.Show();
            Hide();
        }

        //Show this main child login/out screen after the admin form is closed.
        private void AdminFormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        //Close the child sign in/out screen.
        private void btnDone_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* Event handler delegate for all children buttons to sign
         * the specific child in or out.
         * The child object was previously bound to the Tag property
         * of the button in question as a cheap hack/workaround
         * to access the specific child that a button is for.
         * INPUT object sender as button.
         * OUTPUT: Text to gui/button.
         */
        private void btnChild_Click(object sender, EventArgs e)
        {
            //to the passed in sender source and cast it to a Button
            Button button = (Button)sender;

            //here comes that cast we talked about.
            //also: cheap hax
            Child selectedChild = (Child)button.Tag;

            //Sign the student in or out. Logic handled in function.
            SqliteDataAccess.SignChildInOut(selectedChild, guardian);

            //Re-grok the student's status.
            Attendance studentStatus = SqliteDataAccess.GetChildSignInOut(selectedChild);

            //Update the button text.
            string btnText = selectedChild.DisplayName + "\n\r"
                                   + "Status: Signed " + studentStatus.in_out.ToUpper() + "\n\r"
                                   + studentStatus.timestamp;
            button.Text = btnText;

            UpdatePanelColor(button.Parent, studentStatus.in_out);
        }

        /* Updates the child panel color to green if signed in, gray if not signed in.
         * INPUT: Panel as control, string in_out as "in" or "out"
         * OUTPUT: Green color if signed in, gray if not signed in.
         */
        private void UpdatePanelColor(Control control, string in_out_status)
        {
            Panel panel = (Panel)control;

            switch(in_out_status)
            {
                case "in":
                    panel.BackColor = Color.Green;
                    break;
                case "out":
                    panel.BackColor = Color.Gray;
                    break;
                default:
                    break;
            }
        }
    }
}
