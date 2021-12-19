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
    public partial class Login : Form
    {
        SqlConnection con;
        public static string LoginName = "";
        public Login()
        {
            InitializeComponent();
            //string conn = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Anonymous\Documents\Visual Studio 2012\Projects\FaceRecoginazition\FaceRecoginazition\Database1.mdf;Integrated Security=True";
            String conn = @"Server=FM-MMERCADO-L;Initial Catalog=Startup;Integrated Security=SSPI";
            con = new SqlConnection(conn);
        }

        //public void a
        //{
        //    //String connetionString = @"Server=FM-MMERCADO-L;Initial Catalog=Fedoramain;Integrated Security=SSPI";
        //    //String connetionString = @"Data Source=10.10.2.16,1433\SQLEXPRESS;Initial Catalog=Fedoramain;User ID=sa;Password=FMf3dor@2o20;MultipleActiveResultSets=true";

        //    SqlConnection sql_con = new SqlConnection(connetionString);



        //string sqlquery = "UPDATE [dbo].[rdf_recipe_to_production] SET total_qty='" + txtsavetotalqty.Text + "', total_prod='" + lbltotaltheoprod.Text + "', theo_additional_qty ='" + txtgrandtotalvariance.Text + "',grandtotalrpt='" + lblsum.Text + "' WHERE item_code='" + lbltheoitemcode.Text + "'";






        //sql_con.Open();
        //    SqlCommand sql_cmd = new SqlCommand(sqlquery, sql_con);
        //SqlDataAdapter sdr = new SqlDataAdapter(sql_cmd);
        //DataTable dt = new DataTable();
        //sdr.Fill(dt);
        //    dataGridView3.DataSource = dt;

        //    sql_con.Close();
        //        }



        public void SearchUserType()
        {
            String connetionString = @"Server=FM-MMERCADO-L;Initial Catalog=Startup;Integrated Security=SSPI";
            //String connetionString = @"Data Source=10.10.2.16,1433\SQLEXPRESS;Initial Catalog=Fedoramain;User ID=sa;Password=FMf3dor@2o20;MultipleActiveResultSets=true";

            SqlConnection sql_con = new SqlConnection(connetionString);



        string sqlquery = "Select * from LoginUser where uname='"+tone.Text+"'";






        sql_con.Open();
            SqlCommand sql_cmd = new SqlCommand(sqlquery, sql_con);
        SqlDataAdapter sdr = new SqlDataAdapter(sql_cmd);
        DataTable dt = new DataTable();
        sdr.Fill(dt);
            dgvUserType.DataSource = dt;

            sql_con.Close();
                }

    private void Reg2_Click(object sender, EventArgs e)
        {

            if (tfour.Text != "")
            {
                if (char.IsLower(Convert.ToChar(tfour.Text.Substring(0, 1))))
                {
                    MessageBox.Show("Please write first letter capital of password");
                }
                else
                {
                    string type = "";
                    string querry = "select * from [Startup].[dbo].[LoginUser] where uname='" + tone.Text + "' AND upass='" + tfour.Text + "'";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        type = dr["utype"].ToString();
                        if (type.Equals("Teacher"))
                        {
                            LoginName = tone.Text;

                            TeacherMain tm = new TeacherMain();

                            tm.Show();
                        }
                        else
                        {

                            LoginName = tone.Text;

                            StudentMain sm = new StudentMain();

                            sm.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error in Credientials");

                    }
                    dr.Close();
                    con.Close();
                }
            }
        }
            

        private void button1_Click(object sender, EventArgs e)
        {
            contacts c = new contacts();
            c.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tone.Focus();
            tone.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Make_Attendance asd = new Make_Attendance();
            asd.ShowDialog();
        }

        private void dgvUserType_CurrentCellChanged(object sender, EventArgs e)
        {

            if (dgvUserType.RowCount > 0)
            {
                if (dgvUserType.CurrentRow != null)
                {
                    if (dgvUserType.CurrentRow.Cells["uname"].Value != null)
                    {
                     
                        comboBox1.Text = dgvUserType.CurrentRow.Cells["utype"].Value.ToString();

                        //txtdatenow.Text = dgvApproved.CurrentRow.Cells["added"].Value.ToString();
                    }

                }
            }


            //







        }

        private void tone_TextChanged(object sender, EventArgs e)
        {
            SearchUserType();
        }
    }
}
