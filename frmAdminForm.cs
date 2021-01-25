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
        public static int child_id = 0;

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
            dgvChildren.Rows.Clear();

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

        /* Pop-open a new form for crud operations for children
         * and their guardians. Be sure you set the child_id
         * to -1 here just to be on the super-safe side.
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            child_id = -1; //ENSURE!!!!

            ShowChildCrudForm();
        }

        /* Call the same crud form for adding a new child
         * but store the child_id so the crud form
         * can pick it up on form load.
         */
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /* Get the child's database ID which is secretly hidden
             * in the datagrid view at column 0. Since value is an
             * Object, cast it to Int because that's what we know it is.
             */
            child_id = (int)dgvChildren.CurrentRow.Cells[0].Value;

            ShowChildCrudForm();
        }
        
        /* Seperate function to show the crud form
         * because both the add and the update buttons
         * will show the crud form.
         * INPUT: void
         * OUTPUT: void
         */
        private void ShowChildCrudForm()
        {
            Form frmCrud = new frmChildCrud();
            frmCrud.FormClosed += new FormClosedEventHandler(CrudFormClosed);
            frmCrud.Show();
            Hide();
        }

        //Show this admin screen after the child crud form is closed.
        private void CrudFormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshAdminView();
            Show();
        }

        /* Allow the admin to quit the program as a normal login
         * will not be able to exit the attendence program
         * from the main pin screen on the shared tablet.
         */
        private void btnQuit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using the program! Your data has been saved. Good bye!", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
            Environment.Exit(0);
        }
    }
}
