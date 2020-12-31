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

namespace WindowsFormsApp1
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
            visualComboBox1.Text = "English";
            
                pictureBox66.Visible = false;
                pictureBox88.Visible = true;
            button11.Text = "       Home";
            button33.Text = "       Ways";
            button44.Text = "       Vehicle";
            button66.Text = "       Tickets";
            button77.Text = "       About As";
            button1.Text = "       Localisations";


        }
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        public void Importforminpanel(object Xform)
        {
            if (this.panel44.Controls.Count > 0) { this.panel44.Controls.RemoveAt(0); }
            Form fc = Xform as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.panel44.Controls.Add(fc);
            this.panel44.Tag = fc;
            fc.Show();
        }
      

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panelside.Height = button11.Height;
            panelside.Top = button11.Top;


            this.button11.BackColor = ColorTranslator.FromHtml("#58262F");


            button33.BackColor = ColorTranslator.FromHtml("#1A2530");
            button44.BackColor = ColorTranslator.FromHtml("#1A2530");
            button1.BackColor = ColorTranslator.FromHtml("#1A2530");
            button66.BackColor = ColorTranslator.FromHtml("#1A2530");
            button77.BackColor = ColorTranslator.FromHtml("#1A2530");
            Formhome frm = new Formhome();
            Importforminpanel(new Formhome());
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (panel2.Width == 55)
                for (int i = 1; i < 157; i += 2)
                {
                    panel2.Width += 2;
                }
            // panel2.Width = 212;
            else
                panel2.Width = 55;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelside_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void button33_Click(object sender, EventArgs e)
        {
            panelside.Height = button33.Height;
            panelside.Top = button33.Top;


            this.button33.BackColor = ColorTranslator.FromHtml("#58262F");
            button1.BackColor = ColorTranslator.FromHtml("#1A2530");
            button11.BackColor = ColorTranslator.FromHtml("#1A2530");
            button44.BackColor = ColorTranslator.FromHtml("#1A2530");
            button66.BackColor = ColorTranslator.FromHtml("#1A2530");
            button77.BackColor = ColorTranslator.FromHtml("#1A2530");
             trajetuser frm = new trajetuser();
            Importforminpanel(new trajetuser());
        }

        private void button44_Click(object sender, EventArgs e)
        {
            panelside.Height = button44.Height;
            panelside.Top = button44.Top;


            this.button44.BackColor = ColorTranslator.FromHtml("#58262F");

          
            button33.BackColor = ColorTranslator.FromHtml("#1A2530");
            button11.BackColor = ColorTranslator.FromHtml("#1A2530");           
            button66.BackColor = ColorTranslator.FromHtml("#1A2530");
            button77.BackColor = ColorTranslator.FromHtml("#1A2530");
            button1.BackColor = ColorTranslator.FromHtml("#1A2530");
            vehicle frm = new vehicle();
            Importforminpanel(new vehicle());
        }

        
        private void button66_Click(object sender, EventArgs e)
        {
            panelside.Height = button66.Height;
            panelside.Top = button66.Top;


            this.button66.BackColor = ColorTranslator.FromHtml("#58262F");

            button1.BackColor = ColorTranslator.FromHtml("#1A2530");
            button33.BackColor = ColorTranslator.FromHtml("#1A2530");
            button44.BackColor = ColorTranslator.FromHtml("#1A2530");
            button11.BackColor = ColorTranslator.FromHtml("#1A2530");
            button77.BackColor = ColorTranslator.FromHtml("#1A2530");
            Ticket frm = new Ticket();
            Importforminpanel(new Ticket());
        }

        private void button77_Click(object sender, EventArgs e)
        {
            panelside.Height = button77.Height;
            panelside.Top = button77.Top;


            this.button77.BackColor = ColorTranslator.FromHtml("#58262F");

            button1.BackColor = ColorTranslator.FromHtml("#1A2530");
            button33.BackColor = ColorTranslator.FromHtml("#1A2530");
            button44.BackColor = ColorTranslator.FromHtml("#1A2530");            
            button66.BackColor = ColorTranslator.FromHtml("#1A2530");
            button11.BackColor = ColorTranslator.FromHtml("#1A2530");
            AboutAS frm = new AboutAS(new Form2());
            Importforminpanel(new AboutAS(new Form2()));

        }

        private void visualComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (visualComboBox1.Text == "Français")
            {
                pictureBox88.Visible = false;
                pictureBox66.Visible = true;
                button11.Text = "       Acceuil";
                button33.Text = "       Trajet";
                button44.Text = "       Vehicule";
                button66.Text = "       Tickets";
                button77.Text = "       Apropos";
                button1.Text = "       Localisations";


            }
            if (visualComboBox1.Text == "English")
            {
                     pictureBox66.Visible = false;
                     pictureBox88.Visible = true;
                button11.Text = "       Home";
                button33.Text = "       Ways";
                button44.Text = "       Vehicle";
                button66.Text = "       Tickets";
                button77.Text = "       About As";
                button1.Text = "       Localisations";
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelside.Height = button1.Height;
            panelside.Top = button1.Top;


            this.button1.BackColor = ColorTranslator.FromHtml("#58262F");


            button33.BackColor = ColorTranslator.FromHtml("#1A2530");
            button44.BackColor = ColorTranslator.FromHtml("#1A2530");
            button66.BackColor = ColorTranslator.FromHtml("#1A2530");
            button11.BackColor = ColorTranslator.FromHtml("#1A2530");
            button77.BackColor = ColorTranslator.FromHtml("#1A2530");
            integrerMaps frm = new integrerMaps();
            Importforminpanel(new integrerMaps());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox55_Click(object sender, EventArgs e)
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
    }
}
