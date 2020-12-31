using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        private void Form3_Load(object sender, EventArgs e)
        {
            //chnu hewa lmuxhkil ?!!
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void jMetroTextBox3_Load(object sender, EventArgs e)
        {
        }

        private void jMetroTextBox3_Enter(object sender, EventArgs e)
        {
            if (jMetroTextBox3.TextName == "UserName")
            {
                jMetroTextBox3.TextName = "";
            }
            if (jMetroTextBox1.IsPassword == false)
            {
                jMetroTextBox1.IsPassword = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            if (jMetroTextBox1.TextName == "")
            {
                jMetroTextBox1.TextName = "Password";
            }
        }

        private void jMetroTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void jMetroTextBox1_Enter(object sender, EventArgs e)
        {
            if (jMetroTextBox1.IsPassword == false)
            {
                jMetroTextBox1.IsPassword = true;
            }
            if (jMetroTextBox1.TextName == "Password")
            {
                jMetroTextBox1.TextName = "";
            }
            if (jMetroTextBox3.TextName == "")
            {
                jMetroTextBox3.TextName = "UserName";
            }
        }

        private void jMetroTextBox1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            jMetroTextBox1.IsPassword = false;
            pictureBox5.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            jMetroTextBox1.IsPassword = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
        }

        private void isButton1_Click(object sender, EventArgs e)
        {//kan tfa lia lwifi 
           //sf khdmat?? att njereb user
            try
            {
                cnx.cn.Open();
                SqlCommand cmd = new SqlCommand("select count(*), sess from identifier where nom = '" + jMetroTextBox3.TextName + "' and mdp = '" + jMetroTextBox1.TextName + "' group by sess", cnx.cn);
                SqlDataReader dr;
                int exist = 0;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    exist = int.Parse(dr[0].ToString());
                    if (exist == 1)
                    {
                        int session = int.Parse(dr[1].ToString());
                        cnx.cn.Close();
                        if (session == 1) { 
                          // ActiveForm.Hide();
                            Form2 s = new Form2();
                            s.Show();
                           
                        }
                        else
                        {
                            
                            user s = new user();
                            s.Show();
                          //  ActiveForm.Close();
                        }

                    }
                    

                }
                else
                {
                    MessageBox.Show("Username ou mot de passe et incorrecte...", "user or pass invalid", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                cnx.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
