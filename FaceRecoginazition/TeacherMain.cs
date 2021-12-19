using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecoginazition
{
    public partial class TeacherMain : Form
    {
        public TeacherMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_Record vr = new View_Record();
            vr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditRecord er = new EditRecord();
            er.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete d = new Delete();
            d.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Make_Attendance ma = new Make_Attendance();
            ma.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            contacts c = new contacts();
            c.Show();
        }
    }
}
