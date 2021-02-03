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
    public partial class frmReports : Form
    {
        //globals for cheap access.
        SqliteDataAccess SqliteDataAccess = new SqliteDataAccess();

        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            LoadFilterComboBox();
        }

        private void LoadFilterComboBox()
        {
            List<Child> children = new List<Child>();
            Child everyoneSelection = new Child();

            /* cheap hack since you can't add an item to
             * a combobox that has existing databinding.
             */
            everyoneSelection.id = 0;
            everyoneSelection.DisplayName = "Everyone";

            children = SqliteDataAccess.GetAllChildren();
            children.Insert(0, everyoneSelection);

            cbChildPicker.DataSource = children;
        }
    }
}
