using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace FaceRecoginazition
{
    public partial class EditRecord : Form
    {
        SqlConnection con;
        public EditRecord()
        {
           
            InitializeComponent();
            string conn = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Anonymous\Documents\Visual Studio 2012\Projects\FaceRecoginazition\FaceRecoginazition\Database1.mdf;Integrated Security=True";
            con = new SqlConnection(conn);
        }

        private void EditRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBEdit.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.dBEdit.Attendance);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                string querry = "update Attendance set sAttendance='" + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "', sDate='" + dataGridView1.SelectedRows[0].Cells[2].Value.ToString() + "',sTime='" + dataGridView1.SelectedRows[0].Cells[3].Value.ToString() + "',uname='" + dataGridView1.SelectedRows[0].Cells[4].Value.ToString() + "' WHERE Id='" + id + "'";
                SqlCommand cmd = new SqlCommand(querry, con);
                con.Open();
                int aa = cmd.ExecuteNonQuery();
                if (aa != 0)
                {
                    MessageBox.Show("Data is Updated");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = this.dBEdit.Attendance;
                   
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            else
            {
                MessageBox.Show("Please Select row first Or Invalid Data", "Warning");

            }
            con.Close();
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
