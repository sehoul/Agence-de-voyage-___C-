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
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            visualComboBox1.Text ="English";
            
                pictureBox6.Visible = false;
                pictureBox8.Visible = true;
                button1.Text = "       Home";
                button5.Text = "       Employes";
                button3.Text = "       Ways";
                button4.Text = "       Vehicle";
                button2.Text = "       Archives";
                button6.Text = "       Travels";
                button7.Text = "       About As";
             
        }
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        private void pictureBox1_Click(object sender, EventArgs e)
        {
             if (panel2.Width == 55)
                for(int i= 1;i<157;i+=2)
                {
                    panel2.Width += 2;
                }
               // panel2.Width = 212;
            else
                panel2.Width = 55;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelside.Height = button1.Height;
            panelside.Top = button1.Top;


            this.button1.BackColor = ColorTranslator.FromHtml("#304E56");

            button2.BackColor = ColorTranslator.FromHtml("#393E46");
            button3.BackColor = ColorTranslator.FromHtml("#393E46");
            button4.BackColor = ColorTranslator.FromHtml("#393E46");
            button5.BackColor = ColorTranslator.FromHtml("#393E46");
            button6.BackColor = ColorTranslator.FromHtml("#393E46");
            button7.BackColor = ColorTranslator.FromHtml("#393E46");
            Formhome frm = new Formhome();
            importforminpanel(new Formhome());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelside.Height = button2.Height;
            panelside.Top = button2.Top;
            this.button2.BackColor = ColorTranslator.FromHtml("#304E56");

            button1.BackColor = ColorTranslator.FromHtml("#393E46");
            button3.BackColor = ColorTranslator.FromHtml("#393E46");
            button4.BackColor = ColorTranslator.FromHtml("#393E46");
            button5.BackColor = ColorTranslator.FromHtml("#393E46");
            button6.BackColor = ColorTranslator.FromHtml("#393E46");
            button7.BackColor = ColorTranslator.FromHtml("#393E46");
            Form5 frm = new Form5();
            importforminpanel(new Form5());

        }

        private void importforminpanel(object Xform)
        {
            if (this.panel4.Controls.Count > 0) { this.panel4.Controls.RemoveAt(0); }
            Form fc = Xform as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(fc);
            this.panel4.Tag = fc;
            fc.Show();
        } 

        private void button3_Click(object sender, EventArgs e)
        {
            panelside.Height = button3.Height;
            panelside.Top = button3.Top;
            this.button3.BackColor = ColorTranslator.FromHtml("#304E56");

            button2.BackColor = ColorTranslator.FromHtml("#393E46");
            button1.BackColor = ColorTranslator.FromHtml("#393E46");
            button4.BackColor = ColorTranslator.FromHtml("#393E46");
            button5.BackColor = ColorTranslator.FromHtml("#393E46");
            button6.BackColor = ColorTranslator.FromHtml("#393E46");
            button7.BackColor = ColorTranslator.FromHtml("#393E46");
            Form10 frm = new Form10();
            importforminpanel(new Form10());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelside.Height = button4.Height;
            panelside.Top = button4.Top;
            this.button4.BackColor = ColorTranslator.FromHtml("#304E56");

            button2.BackColor = ColorTranslator.FromHtml("#393E46");
            button3.BackColor = ColorTranslator.FromHtml("#393E46");
            button1.BackColor = ColorTranslator.FromHtml("#393E46");
            button5.BackColor = ColorTranslator.FromHtml("#393E46");
            button6.BackColor = ColorTranslator.FromHtml("#393E46");
            button7.BackColor = ColorTranslator.FromHtml("#393E46");
            Form11 frm = new Form11();
            importforminpanel(new Form11());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelside.Height = button5.Height;
            panelside.Top = button5.Top;
            this.button5.BackColor = ColorTranslator.FromHtml("#304E56");

            button2.BackColor = ColorTranslator.FromHtml("#393E46");
            button3.BackColor = ColorTranslator.FromHtml("#393E46");
            button4.BackColor = ColorTranslator.FromHtml("#393E46");
            button1.BackColor = ColorTranslator.FromHtml("#393E46");
            button6.BackColor = ColorTranslator.FromHtml("#393E46");
            button7.BackColor = ColorTranslator.FromHtml("#393E46");
            Form4 frm = new Form4();
            importforminpanel(new Form4());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelside.Height = button6.Height;
            panelside.Top = button6.Top;
            this.button6.BackColor = ColorTranslator.FromHtml("#304E56");

            button2.BackColor = ColorTranslator.FromHtml("#393E46");
            button3.BackColor = ColorTranslator.FromHtml("#393E46");
            button4.BackColor = ColorTranslator.FromHtml("#393E46");
            button5.BackColor = ColorTranslator.FromHtml("#393E46");
            button1.BackColor = ColorTranslator.FromHtml("#393E46");
            button7.BackColor = ColorTranslator.FromHtml("#393E46");
            voyageF frm = new voyageF();
            importforminpanel(new voyageF());
        }
        public string lng;
       
        private void button7_Click(object sender, EventArgs e)
        {
            panelside.Height = button7.Height;
            panelside.Top = button7.Top;
            this.button7.BackColor = ColorTranslator.FromHtml("#304E56");
            
            button2.BackColor = ColorTranslator.FromHtml("#393E46");
            button3.BackColor = ColorTranslator.FromHtml("#393E46");
            button4.BackColor = ColorTranslator.FromHtml("#393E46");
            button5.BackColor = ColorTranslator.FromHtml("#393E46");
            button6.BackColor = ColorTranslator.FromHtml("#393E46");
            button1.BackColor = ColorTranslator.FromHtml("#393E46");
            AboutAS frm = new AboutAS(new Form2());
             importforminpanel(new AboutAS(new Form2()));
           
        }

        private void panelside_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (isPanel1.Visible == true)
            {
                isPanel1.Visible = false;
            }

            else
            {
                isPanel1.Visible = true;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)//att d9i9a
        {             if(panel5.Visible == true)
             panel5.Visible = false;
            else
                panel5.Visible = true;
            SqlCommand cmd = new SqlCommand("select count(*) from Voyage where   date_D=FORMAT(GETDATE(), 'dd-MM-yyyy') ;", cnx.cn);
            cnx.cn.Open();
            int exist = (int)cmd.ExecuteScalar();
            cnx.cn.Close();
            if (exist > 0)
            {
                linkLabel1.Text = "( " + exist + " )" + " voyage va sortie aujhourd'hui !!!";
                pictureBox9.Visible = true;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void visualComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (visualComboBox1.Text == "Français")
            {
                pictureBox6.Visible = true;
                pictureBox8.Visible = false;
                button1.Text = "       Acceuil";
                button5.Text = "       Employes";
                button3.Text = "       Trajet";
                button4.Text = "       Vehicule";
                button2.Text = "       Archives";
                button6.Text = "       Voyages";
                button7.Text = "       Apropos";
                lng = visualComboBox1.Text;
            }
            if (visualComboBox1.Text == "English")
            {
                pictureBox6.Visible = false;
                pictureBox8.Visible = true;
                button1.Text = "       Home";
                button5.Text = "       Employes";
                button3.Text = "       Ways";
                button4.Text = "       Vehicle";
                button2.Text = "       Archives";
                button6.Text = "       Travels";
                button7.Text = "       About As";
                lng = visualComboBox1.Text;
            }
        }
        public string Lng()
        {
            return lng;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
             Form3 frm = new Form3();
              frm.Show();

            
             //   Form3 frm = new Form3();
            //  frm.Show();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
       
            linkLabel1.Text = "(0) voyage va sortir aujhourd'hui !!!";
            SqlCommand cmd = new SqlCommand("select count(*) from Voyage where   date_D=FORMAT(GETDATE(), 'dd-MM-yyyy') ;", cnx.cn);
            cnx.cn.Open();
            int exist = (int)cmd.ExecuteScalar();
            cnx.cn.Close();
            if (exist > 0)
            {
                linkLabel1.Text = "( " + exist + " )" + " voyage va sortie aujhourd'hui !!!";
                pictureBox9.Visible = true;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VoyageA vf = new VoyageA();
            vf.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            
                 
           }
    }
}
