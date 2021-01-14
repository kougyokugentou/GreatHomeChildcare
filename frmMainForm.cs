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

            //For each child, present a new button to sign the student in/out.
            foreach (Child c in children)
            {
                //Button b = new Button();
            }

            //TODO: remove once I figure out how to add new button, perhaps to a table layout panel.
            Console.WriteLine("test");
        }

        //TODO: implement via another form.
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The admin button was clicked.");
        }
    }
}
