using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class integrerMaps : Form
    {
        Timer timer3 = new Timer();
        public integrerMaps()
        {
            InitializeComponent();
            timer3.Interval = 10;
            timer3.Tick += new EventHandler(timer3_go);
           // timer3.Start();

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void visualPanel1_Paint(object sender, PaintEventArgs e)
        {
            Maps op = new Maps();
            op.Show();
        }
        void timer3_go(object sender, EventArgs e)
        {
            
                reg();
          
        }
        int move_speed =8;
        void reg()
        {
            if (isButton1.Width < 132)
            {

                isButton1.Width += move_speed;
                if (isButton1.Width == 132)
                {
                    timer3.Stop();
                }
            }
        }


        private void isButton1_MouseHover(object sender, EventArgs e)
        {
            timer3.Start();
            //for (int i = 0; i < 70; i++) isButton1.Width += 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

            Maps op = new Maps();
            op.Show();
        }

        private void isButton1_Click(object sender, EventArgs e)
        {

            Maps op = new Maps();
            op.Show();
        }
    }
}
