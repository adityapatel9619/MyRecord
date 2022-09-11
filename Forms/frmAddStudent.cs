using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dskMyStudents.Forms
{
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void tbfname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbfname.Text.Trim()))
            {
                efname.SetError(tbfname, "First name is required.");
            }
            else
            {
                efname.SetError(tbfname, string.Empty);
            }
            if (string.IsNullOrEmpty(tbmname.Text.Trim()))
            {
                eMname.SetError(tbmname, "Middle name is required.");
            }
            else
            {
                eMname.SetError(tbmname, string.Empty);
            }
            if (string.IsNullOrEmpty(tblname.Text.Trim()))
            {
                elname.SetError(tblname, "Last name is required.");
            }
            else
            {
                elname.SetError(tblname, string.Empty);
            }
        }
    }
}
