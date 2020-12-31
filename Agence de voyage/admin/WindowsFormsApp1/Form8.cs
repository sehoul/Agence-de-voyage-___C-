using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
namespace WindowsFormsApp1
{

    public partial class Formhome : Form
    {
        private static int i=0;


        Timer t1 = new Timer();
        Timer t2 = new Timer();

        public Formhome()
        {
            InitializeComponent();
            // Form8.BackgroundImage = photos[i];
            // Formhome.ImageLocation = photos[i];
            t1.Tick += new EventHandler(changer);
            t1.Interval = 5;
            t2.Tick += new EventHandler(changerinv);
            t2.Interval = 5;
        }

         void changer(object sender, EventArgs e)
        {

            if (i == 1)
            {
                this.BackgroundImage = Properties.Resources.Fichier_19;
                t1.Stop();
               // i += 1;
            }
            if (i == 2)
            {
                this.BackgroundImage = Properties.Resources.Fichier_20;
                t1.Stop();
                // i += 1;
            }
            if (i == 3) { this.BackgroundImage = Properties.Resources.Fichier_21;
                t1.Stop();
            }
            if (i == 4)
            {
                this.BackgroundImage = Properties.Resources.Fichier_22;
                t1.Stop();
            }
            if (i == 5)
            {
                this.BackgroundImage = Properties.Resources.Fichier_23;
                t1.Stop();
            }
            if (i == 6)
            {
                this.BackgroundImage = Properties.Resources.Fichier_24;
                t1.Stop();
            }
            if (i == 7)
            {
                this.BackgroundImage = Properties.Resources.Fichier_25;
                t1.Stop();
            }
            if (i == 8)
            {
                this.BackgroundImage = Properties.Resources.Fichier_26;
                t1.Stop();
            }
            if (i == 9)
            {
                this.BackgroundImage = Properties.Resources.Fichier_27;
                t1.Stop();
            }
            if (i == 10)
            {
                this.BackgroundImage = Properties.Resources.Fichier_28 ;
                i = 0;
                t1.Stop();
               
               
            }
        }
        void changerinv(object sender, EventArgs e)
        {

            if (i == 1 || i == -10)
            {
                if (i == -10) i = 0;
                this.BackgroundImage = Properties.Resources.Fichier_19;
                t1.Stop();
                // i += 1;
            }
            if (i == 2 || i == -9)
            {
                this.BackgroundImage = Properties.Resources.Fichier_20;
                t1.Stop();
                // i += 1;
            }
            if (i == 3 || i == -8)
            {
                this.BackgroundImage = Properties.Resources.Fichier_21;
                t1.Stop();
            }
            if (i == 4 || i == -7)
            {
                this.BackgroundImage = Properties.Resources.Fichier_22;
                t1.Stop();
            }
            if (i == 5 || i == -6)
            {
                this.BackgroundImage = Properties.Resources.Fichier_23;
                t1.Stop();
            }
            if (i == 6 || i == -5)
            {
                this.BackgroundImage = Properties.Resources.Fichier_24;
                t1.Stop();
            }
            if (i == 7 || i == -4)
            {
                this.BackgroundImage = Properties.Resources.Fichier_25;
                t1.Stop();
            }
            if (i == 8 || i == -3)
            {
                this.BackgroundImage = Properties.Resources.Fichier_26;
                t1.Stop();
            }
            if (i == 9 || i == -2)
            {
                this.BackgroundImage = Properties.Resources.Fichier_27;
                t1.Stop();
            }
            if (i == 10||i==-1)
            {
                this.BackgroundImage = Properties.Resources.Fichier_28;
                if (i == 10) i = 0;
                t1.Stop();
            }
        }
        private void visualLabel1_Click(object sender, EventArgs e)
        {

        }
       
        private void jThinButton2_Click(object sender, EventArgs e)
        {
            i += 1;
            t1.Start();
           
            /*if (i == 1)
            {
                this.BackgroundImage = Properties.Resources.Fichier_19;
                i += 1;
            }
            if (i == 2)
            {
                this.BackgroundImage = Properties.Resources.Fichier_20;
                i += 1;
            }
            if (i == 3) { this.BackgroundImage = Properties.Resources.Fichier_21; }*/

            //  Form8.BackgroundImage = photos[i];
            // Form8.//tswira machi hia hadik att nchufuok
            //attattatta
        }

        private void Formhome_Load(object sender, EventArgs e)
        {
            //had le code dyl ticket khass ndiroh f projet d client ah
        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            i -= 1;
            t2.Start();
        }

   
    }
}
