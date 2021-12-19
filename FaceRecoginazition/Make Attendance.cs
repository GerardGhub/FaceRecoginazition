using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;

namespace FaceRecoginazition
{
    public partial class Make_Attendance : Form
    {
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        string finalname;
        HaarCascade eye;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name, names = null;
        SqlConnection con, con2, con3;
        public Make_Attendance()
        {
            InitializeComponent();
            String constr = @"Server=FM-MMERCADO-L;Initial Catalog=Startup;Integrated Security=SSPI";
            //string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Anonymous\Documents\Visual Studio 2012\Projects\FaceRecoginazition\FaceRecoginazition\Database1.mdf;Integrated Security=True";
            con = new SqlConnection(constr);
            con2 = new SqlConnection(constr);
            con3 = new SqlConnection(constr);
            //Load haarcascades for face detection
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            //eye = new HaarCascade("haarcascade_eye.xml");
            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
                MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grabber = new Capture();
            grabber.QueryFrame();
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Trained face counter
                ContTrain = ContTrain + 1;

                //Get a gray frame from capture device
                gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //Face Detector
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                face,
                1.2,
                10,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));

                //Action for each element detected
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                    break;
                }

                //resize face detected image for force to compare the same size with the 
                //test image with cubic interpolation type method
                TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                trainingImages.Add(TrainedFace);
                labels.Add(comboBox1.SelectedItem.ToString());

                //Show face added in gray scale
                imageBox1.Image = TrainedFace;

                //Write the number of triained faces in a file text for further load
                File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

                //Write the labels of triained faces in a file text for further load
                for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                {
                    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
                    File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
                }

                MessageBox.Show(comboBox1.SelectedItem.ToString() + "´s face detected and added :)", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void imageBoxFrameGrabber_Click(object sender, EventArgs e)
        {

        }

        private void label3_TextChanged(object sender, EventArgs e)
        {
            if (label4.Text == ",")
            {
                label4.Text = "Undefined";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString();

            //SearchAttendance();
        }

        void FrameGrabber(object sender, EventArgs e)
        {
            label3.Text = "0";
            //label4.Text = "";
            NamePersons.Add("");

            //320 240
            //Get the current frame form capture device
            currentFrame = grabber.QueryFrame().Resize(858, 630, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Convert it to Grayscale
            gray = currentFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
          face,
          1.2,
          10,
          Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
          new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                t = t + 1;
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //draw the face detected in the 0th (gray) channel with blue color
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);


                if (trainingImages.ToArray().Length != 0)
                {

                    //TermCriteria for face recognition with numbers of trained images like maxIteration
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                    //Eigen face recognizer
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                       trainingImages.ToArray(),
                       labels.ToArray(),
                       3000,
                       ref termCrit);

                    name = recognizer.Recognize(result);
                    // MessageBox.Show("" + name);
                    // textBox2.Text = name;
                    finalname = name;
                    //Draw the label for each face detected and recognized
                    currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));

                }

                NamePersons[t - 1] = name;
                NamePersons.Add("");


                //Set the number of faces detected on the scene
                label3.Text = facesDetected[0].Length.ToString();

                /*
                //Set the region of interest on the faces
                        
                gray.ROI = f.rect;
                MCvAvgComp[][] eyesDetected = gray.DetectHaarCascade(
                   eye,
                   1.1,
                   10,
                   Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                   new Size(20, 20));
                gray.ROI = Rectangle.Empty;

                foreach (MCvAvgComp ey in eyesDetected[0])
                {
                    Rectangle eyeRect = ey.rect;
                    eyeRect.Offset(f.rect.X, f.rect.Y);
                    currentFrame.Draw(eyeRect, new Bgr(Color.Blue), 2);
                }
                 */

            }
            t = 0;

            //Names concatenation of persons recognized
            for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
            {
                names = names + NamePersons[nnn] + ", ";

            }
            //Show the faces procesed and recognized
            imageBoxFrameGrabber.Image = currentFrame;
       

   
           
                label4.Text = names;
            
            if (names != null)
            {
                 //MessageBox.Show(NamePersons[0]);
                getdetails(NamePersons[0]);
                getdetails_lunch_out(NamePersons[0]);
                getdetails_lunch_in(NamePersons[0]);
                getdetails_time_out(NamePersons[0]);
            }
            names = "";
            //Clear the list(vector) of names
            NamePersons.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // textBox2.Text = finalname;
            //MessageBox.Show("" + finalname + " ");
            //textBox3.Text = DateTime.Now.ToShortDateString();
            // textBox4.Text = DateTime.Now.ToShortTimeString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private string getdetails(string name)
        {
            string id = "";
            string querry = "select * from [Startup].[dbo].[LoginUser] where uname='"+name+"'";
            SqlCommand cmd = new SqlCommand(querry, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = dr["user_id"].ToString();
                //MessageBox.Show("" + id);
                string currentdate = DateTime.Now.ToShortDateString();
                string getval = checkalreadypresent(id, currentdate);
                
                if (getval.Equals("no"))
                {
                    string present = "present";
                    string querry2 = "insert into Attendance(sAttendance,sDate,uid,sTime,uname)values('" + present + "','" + currentdate + "','"+id+"','" + DateTime.Now.ToShortTimeString() + "',(select uname from [Startup].[dbo].[LoginUser] where user_id='"+id+ "'))";
                    SqlCommand cmd2 = new SqlCommand(querry2, con2);
                    con2.Open();
                    int a = cmd2.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Record Added");
                        SearchAttendance();

                    }
                    else
                    {
                        MessageBox.Show("Error");

                    }
                    con2.Close();
                }

            }
            else
            {
               // MessageBox.Show("No Names detected");

            }
            dr.Close();
            con.Close();
            return id;
        }



        private string getdetails_lunch_out(string name)
        {
            string id = "";
            string querry = "select * from [Startup].[dbo].[LoginUser] where uname='" + name + "'";
            SqlCommand cmd = new SqlCommand(querry, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = dr["user_id"].ToString();
                //MessageBox.Show("" + id);
                string currentdate = DateTime.Now.ToShortDateString();
                string getval = checkalreadypresent_lunch_out(id, currentdate);

                if (getval.Equals("no"))
                {
                    //string present = "present";
                    string querry2 = "Update Attendance Set lunch_out ='" + DateTime.Now.ToShortTimeString() + "' where sDate='" + currentdate + "' AND uid='" + id + "'";
                    SqlCommand cmd2 = new SqlCommand(querry2, con2);
                    con2.Open();
                    int a = cmd2.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Record Added Lunch Out");
                        SearchAttendance();

                    }
                    else
                    {
                        MessageBox.Show("Error");

                    }
                    con2.Close();
                }

            }
            else
            {
                // MessageBox.Show("No Names detected");

            }
            dr.Close();
            con.Close();
            return id;
        }

        private string getdetails_lunch_in(string name)
        {
            string id = "";
            string querry = "select * from [Startup].[dbo].[LoginUser] where uname='" + name + "'";
            SqlCommand cmd = new SqlCommand(querry, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = dr["user_id"].ToString();
                //MessageBox.Show("" + id);
                string currentdate = DateTime.Now.ToShortDateString();
                string getval = checkalreadypresent_lunch_in(id, currentdate);

                if (getval.Equals("no"))
                {
                    //string present = "present";
                    string querry2 = "Update Attendance Set lunch_in ='" + DateTime.Now.ToShortTimeString() + "' where sDate='" + currentdate + "' AND uid='" + id + "'";
                    SqlCommand cmd2 = new SqlCommand(querry2, con2);
                    con2.Open();
                    int a = cmd2.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Record Added Lunch IN");
                        SearchAttendance();

                    }
                    else
                    {
                        MessageBox.Show("Error");

                    }
                    con2.Close();
                }

            }
            else
            {
                // MessageBox.Show("No Names detected");

            }
            dr.Close();
            con.Close();
            return id;
        }


        private string getdetails_time_out(string name)
        {
            string id = "";
            string querry = "select * from [Startup].[dbo].[LoginUser] where uname='" + name + "'";
            SqlCommand cmd = new SqlCommand(querry, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = dr["user_id"].ToString();
                //MessageBox.Show("" + id);
                string currentdate = DateTime.Now.ToShortDateString();
                string getval = checkalreadypresent_time_out(id, currentdate);

                if (getval.Equals("no"))
                {
                    //string present = "present";
                    string querry2 = "Update Attendance Set time_out ='" + DateTime.Now.ToShortTimeString() + "' where sDate='" + currentdate + "' AND uid='" + id + "'";
                    SqlCommand cmd2 = new SqlCommand(querry2, con2);
                    con2.Open();
                    int a = cmd2.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Record Added Time Out");
                        SearchAttendance();

                    }
                    else
                    {
                        MessageBox.Show("Error");

                    }
                    con2.Close();
                }

            }
            else
            {
                // MessageBox.Show("No Names detected");

            }
            dr.Close();
            con.Close();
            return id;
        }
        private string checkalreadypresent(string id, string date)
        {
            string val = "";
            string querry3 = "select * from [Startup].[dbo].[Attendance] where uid='" + id + "' AND sDate='" + date + "' AND sTime IS NOT NULL";
            SqlCommand cmd = new SqlCommand(querry3, con3);
            con3.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                val = "yes";
            }
            else
            {
                val = "no";
            }
            con3.Close();
            return val;
        }



        private string checkalreadypresent_lunch_out(string id, string date)
        {
            string val = "";
            string querry3 = "select * from [Startup].[dbo].[Attendance] where uid='" + id + "' AND sDate='" + date + "' AND lunch_in IS NOT NULL";
            SqlCommand cmd = new SqlCommand(querry3, con3);
            con3.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                val = "yes";
            }
            else
            {
                val = "no";
            }
            con3.Close();
            return val;
        }

        private string checkalreadypresent_lunch_in(string id, string date)
        {
            string val = "";
            string querry3 = "select * from [Startup].[dbo].[Attendance] where uid='" + id + "' AND sDate='" + date + "' AND lunch_in IS NOT NULL";
            SqlCommand cmd = new SqlCommand(querry3, con3);
            con3.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                val = "yes";
            }
            else
            {
                val = "no";
            }
            con3.Close();
            return val;
        }

        private string checkalreadypresent_time_out(string id, string date)
        {
            string val = "";
            string querry3 = "select * from [Startup].[dbo].[Attendance] where uid='" + id + "' AND sDate='" + date + "' AND time_out IS NOT NULL";
            SqlCommand cmd = new SqlCommand(querry3, con3);
            con3.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                val = "yes";
            }
            else
            {
                val = "no";
            }
            con3.Close();
            return val;
        }

        private void Make_Attendance_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            timer1_Tick(sender, e);
            SearchAttendance();
            //button2_Click(sender, e);
        }


        public void SearchAttendance()
        {
            String connetionString = @"Server=FM-MMERCADO-L;Initial Catalog=Startup;Integrated Security=SSPI";
            //String connetionString = @"Data Source=10.10.2.16,1433\SQLEXPRESS;Initial Catalog=Fedoramain;User ID=sa;Password=FMf3dor@2o20;MultipleActiveResultSets=true";

            SqlConnection sql_con = new SqlConnection(connetionString);



            string sqlquery = "Select * from Attendance order by id DESC";






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
