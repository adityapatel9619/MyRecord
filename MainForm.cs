using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dskMyStudents.Forms;

namespace dskMyStudents
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStudent addStudent = new frmAddStudent();
            addStudent.MdiParent = MainForm.ActiveForm;
            addStudent.Show();
        }
    }
}
