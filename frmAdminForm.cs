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
    public partial class frmAdminForm : Form
    {
        //globals for cheap access.
        SqliteDataAccess SqliteDataAccess = new SqliteDataAccess();

        public frmAdminForm()
        {
            InitializeComponent();
        }

        private void frmAdminForm_Load(object sender, EventArgs e)
        {
            List<Child> children = new List<Child>();
            children = SqliteDataAccess.GetAllChildren();

            foreach(Child c in children)
            {
                Image photo = (c.photo != null) ? ImageWrangler.ByteArrayToImage(c.photo) : Properties.Resources.child;

                dgvChildren.Rows.Add(c.id, photo, c.DisplayName);
            }
        }
    }
}
