using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class formtest : Form
    {
        public formtest()
        {
            InitializeComponent();
           
        }
        int r = 255;
        int g = 255;
        int b = 255;
        //rf=64;
        //gf=80;
        //bf=137;


        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
            // textBox1.BackColor = Color.FromArgb(r, g, b);
            timerR.Start();
        }


        private void timerR_Tick(object sender, EventArgs e)
        {
            /* if (b >= 244)
             {
                 r -= 1;
                 this.BackColor = Color.FromArgb(r, g, b);
                // textBox1.BackColor = Color.FromArgb(r, g, b);
                 if (r <= 65)
                 {
                     timerR.Stop();
                     timerG.Start();

                    // textBox1.Text = "hola";
                 }
             }

             if (b <= 65)
             {
                 r += 1;
                 this.BackColor = Color.FromArgb(r, g, b);
               //  textBox1.BackColor = Color.FromArgb(r, g, b);
                 if (r >= 244)
                 {
                     timerR.Stop();
                     timerG.Start();

                    // textBox1.Text = "kamusta";
                 }
             }*/
            if (g >=81) {
                if(r>=65)
                r -= 3;
                if(b>=139)
                 b -= 4;
                g -= 2;

                this.BackColor = Color.FromArgb(r, g, b);
                // textBox1.BackColor = Color.FromArgb(r, g, b);
                if (b <= 137 && r<= 64 && g <= 80)
                {
                    timerR.Stop();
                    //   timerG.Start();

                    // textBox1.Text = "hola";

                }
            }
        }

        private void timerG_Tick(object sender, EventArgs e)
        {
            /* if (r <= 65)
             {
                 g += 1;
                 this.BackColor = Color.FromArgb(r, g, b);
               //  textBox1.BackColor = Color.FromArgb(r, g, b);
                 if (g >= 244)
                 {
                     timerG.Stop();
                     timerB.Start();

                    // textBox1.Text = "??????";
                 }
             }

             if (r >= 244)
             {
                 g -= 1;
                 this.BackColor = Color.FromArgb(r, g, b);
               //  textBox1.BackColor = Color.FromArgb(r, g, b);
                 if (g <= 65)
                 {
                     timerG.Stop();
                     timerB.Start();

                   //  textBox1.Text = "??????";
                 }
             }
            if (b>= 254)
            {
                g -= 1;
                this.BackColor = Color.FromArgb(r, g, b);
                // textBox1.BackColor = Color.FromArgb(r, g, b);
                if (g <= 79)
                {
                    timerG.Stop();
                    timerB.Start();

                    // textBox1.Text = "hola";
                }
            }
            */
        }

        private void timerB_Tick(object sender, EventArgs e)
        {
            /* if (g <= 65)
             {
                 b += 1;
                 this.BackColor = Color.FromArgb(r, g, b);
               //  textBox1.BackColor = Color.FromArgb(r, g, b);
                 if (b >= 244)
                 {
                     timerB.Stop();
                     timerR.Start();

                   //  textBox1.Text = "hello";
                 }
             }

             if (g >= 244)
             {
                 b -= 1;
                 this.BackColor = Color.FromArgb(r, g, b);
                // textBox1.BackColor = Color.FromArgb(r, g, b);
                 if (b <= 65)
                 {
                     timerB.Stop();
                     timerR.Start();

                  //   textBox1.Text = "Merhaba";
                 }
             }
            if (r <= 65)
            {
                b -= 1;
                this.BackColor = Color.FromArgb(r, g, b);
                // textBox1.BackColor = Color.FromArgb(r, g, b);
                if (b <= 137)
                {
                    timerB.Stop();
                    timerR.Start();

                    // textBox1.Text = "hola";
                }
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerR.Start();
        }

        private void jMaterialTextbox2_Load(object sender, EventArgs e)
        {

        }

        private void jMaterialTextbox5_Load(object sender, EventArgs e)
        {

        }

        private void jMaterialTextbox4_Load(object sender, EventArgs e)
        {

        }

        private void jMaterialTextbox3_Load(object sender, EventArgs e)
        {

        }

        private void jMaterialTextbox1_Load(object sender, EventArgs e)
        {

        }

        private void jMaterialTextbox2_Load_1(object sender, EventArgs e)
        {

        }

        private void jMaterialTextbox3_Load_1(object sender, EventArgs e)
        {

        }

        private void jMaterialTextbox4_Load_1(object sender, EventArgs e)
        {

        }

        private void jMaterialTextbox5_Load_1(object sender, EventArgs e)
        {

        }
    }
}
