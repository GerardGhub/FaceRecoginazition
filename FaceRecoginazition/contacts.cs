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
using System.Text.RegularExpressions;

namespace FaceRecoginazition
{
    public partial class contacts : Form
    { SqlConnection con;
        
        public contacts()
        {
            InitializeComponent();

            String conn = @"Server=FM-MMERCADO-L;Initial Catalog=Startup;Integrated Security=SSPI";

            con = new SqlConnection(conn);
        }

        private void contacts_Load(object sender, EventArgs e)
        {

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

                    string querry = "insert into LoginUser(uname,ucell,upass,utype)values('" + tone.Text + "','" + ttwo.Text + "','" + tfour.Text + "','" + comboBox1.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a != 0)
                    {
                        MessageBox.Show("Inserted");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            
            }
           
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
        }

        private void ttwo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ttwo.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");

            }
        }
    }
}
