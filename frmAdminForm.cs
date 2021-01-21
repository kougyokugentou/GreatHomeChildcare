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

/* Refs:
 * https://stackoverflow.com/questions/10063770/how-to-add-a-new-row-to-datagridview-programmatically
 * https://stackoverflow.com/questions/3370236/changing-the-row-height-of-a-datagridview
 */

namespace GreatHomeChildcare
{
    public partial class frmAdminForm : Form
    {
        //globals for cheap access.
        SqliteDataAccess SqliteDataAccess = new SqliteDataAccess();
        int child_id = 0;

        public frmAdminForm()
        {
            InitializeComponent();
        }

        // Load the datagridview of children when this form opens.
        private void frmAdminForm_Load(object sender, EventArgs e)
        {
            RefreshAdminView();
        }

        /* Load the admin form with a datagridview of
         * all the children in the sql database.
         * the 'id' field is present in the datagridview for easy access
         * but is hidden in the UI.
         * INPUT: List of all children
         * OUTPUT: Datagridview.
         */
        private void RefreshAdminView()
        {
            List<Child> children = new List<Child>();
            children = SqliteDataAccess.GetAllChildren();

            foreach (Child c in children)
            {
                Image photo = (c.photo != null) ? ImageWrangler.ByteArrayToImage(c.photo) : Properties.Resources.child;
                dgvChildren.Rows.Add(c.id, photo, c.DisplayName);
            }
        }

        //Close this screen, we're all done here.
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //TODO: new form to generate reports
        private void btnReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reports button clicked.");
        }

        //TODO: new form to add a new child and their guardian(s)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add button clicked.");
        }

        //TODO: new form(or same form as adding) for updating children
        //PB&J: get currently selected row from dgv, then pass to GetChildByID() to get Child object.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update button clicked.");
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using the program! Your data has been saved. Good bye!", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
            Environment.Exit(0);
        }
    }
}
