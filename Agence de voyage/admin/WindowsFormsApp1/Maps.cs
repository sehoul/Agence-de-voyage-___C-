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
    public partial class Maps : Form
    {
        public Maps()
        {
            InitializeComponent();
        }
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        private void visualButton1_Click(object sender, EventArgs e)
        {
            
            try
            { 

                StringBuilder adress = new StringBuilder();
                adress.Append("http://maps.google.com/maps?q=");
                if (combo.Text == "Oujda")
                    adress.Append("est oujda" + "," + "+");
                else if (combo.Text == "Rabat")
                    adress.Append("est sale" + "," + "+");
                else if (combo.Text == "Casablanca")
                    adress.Append("est  casablanca" + "," + "+");
                else if (combo.Text == "Fes")
                    adress.Append("est  Fes" + "," + "+");
                else if (combo.Text == "Marrakech")
                    adress.Append("est  Marrakech" + "," + "+");

                webBrowser1.Navigate(adress.ToString());


            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error"); }

        }

        private void visualButton1_MouseMove(object sender, MouseEventArgs e)
        {
           if (panel1.Width == 0) { for (int i = 0; i < 98; i++) { panel1.Width += 1; } }
        }

        private void visualButton1_MouseHover(object sender, EventArgs e)
        {
            if (panel1.Width != 0) { int p = panel1.Width; for (int i = 0; i <p; i++) { panel1.Width -= 1; } }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Maps_Load(object sender, EventArgs e)
        {

        }

        private void Maps_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
    
}
