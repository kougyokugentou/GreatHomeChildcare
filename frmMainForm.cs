﻿using System;
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
    public partial class frmMainForm : Form
    {
        //globals for cheap access.
        SqliteDataAccess SqliteDataAccess = new SqliteDataAccess();
        Guardian guardian = new Guardian();

        public frmMainForm()
        {
            InitializeComponent();
        }

        //TODO: Add a button for each child the guardian has.
        //TODO: Add admin button if guardian isAdmin = 1
        private void frmMainForm_Load(object sender, EventArgs e)
        {
            int i = 1; //for iteration

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
                if (i >= 10) //Keep it in your pants, man!!
                {
                    MessageBox.Show("Sorry, the program only supports 9 children per guardian.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;
                }

                Control controls = tableLayoutPanel1.Controls["panelChild" + i];
                controls.Visible = true;
                PopulateButton(child, controls);
                i++;
            }
        }

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
                }
            } //foreach control
        }
        //TODO: implement via another form.
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The admin button was clicked.");
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Close();
        }

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
        }
    }
}
