using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecoginazition
{
    public partial class View_Record : Form
    {
        public View_Record()
        {
            InitializeComponent();
        }

        private void View_Record_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'database1DataSet2.Attendance' table. You can move, or remove it, as needed.
            //this.attendanceTableAdapter.Fill(this.database1DataSet2.Attendance);
            //// TODO: This line of code loads data into the 'database1DataSet1.Attendance' table. You can move, or remove it, as needed.

            SearchAttendance();



        }

        public void SearchAttendance()
        {
            String connetionString = @"Server=FM-MMERCADO-L;Initial Catalog=Startup;Integrated Security=SSPI";
            //String connetionString = @"Data Source=10.10.2.16,1433\SQLEXPRESS;Initial Catalog=Fedoramain;User ID=sa;Password=FMf3dor@2o20;MultipleActiveResultSets=true";

            SqlConnection sql_con = new SqlConnection(connetionString);



            string sqlquery = "Select * from Attendance";






            sql_con.Open();
            SqlCommand sql_cmd = new SqlCommand(sqlquery, sql_con);
            SqlDataAdapter sdr = new SqlDataAdapter(sql_cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dgvUserType.DataSource = dt;

            sql_con.Close();
        }

    }
}
