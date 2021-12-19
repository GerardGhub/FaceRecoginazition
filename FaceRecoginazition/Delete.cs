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
    public partial class Delete : Form
    {
        SqlConnection con;
        public Delete()
        {
            InitializeComponent();
            string conn = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Anonymous\Documents\Visual Studio 2012\Projects\FaceRecoginazition\FaceRecoginazition\Database1.mdf;Integrated Security=True";
            con = new SqlConnection(conn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            if (dataGridView1.Rows.Count > 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
            {
                string querry = "DELETE FROM Attendance WHERE Id='" + id + "'";
                SqlCommand cmd = new SqlCommand(querry, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data is Deleted");
                dataGridView1.DataSource = null;

                dataGridView1.Refresh();
                dataGridView1.DataSource = this.database1DataSet3.Attendance;
            }
            else
            {
                MessageBox.Show("Please Select row first Or Invalid Data", "Warning");

            }
            con.Close();

            dataGridView1.Refresh();
            this.Refresh();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet3.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.database1DataSet3.Attendance);

        }
    }
}
