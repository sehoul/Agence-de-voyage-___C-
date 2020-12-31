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

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        Timer timer2 = new Timer();
        Timer timer3 = new Timer();
        Timer timer4 = new Timer();
        Timer timer5 = new Timer();
        Timer timer6 = new Timer();
        Timer timer7 = new Timer();
        Timer timer8 = new Timer();
        Timer timer88 = new Timer();
        Timer timer9 = new Timer();
        Timer timer10 = new Timer();
        Timer timer11 = new Timer();
        Timer timer12 = new Timer();
        Label logreg = new Label();
        Button b1 = new Button();
        DataSet db = new DataSet();
        public Form1()
        {
            InitializeComponent();
            // this.Size = new Size(693, 507);
            this.Size = new Size(1050,600);
            timer2.Tick += new EventHandler(timer2_go);
            timer3.Tick += new EventHandler(paneltr);
            timer4.Tick += new EventHandler(timer4_go);
            timer5.Tick += new EventHandler(timer5_go);
            timer6.Tick += new EventHandler(panelret);
            timer7.Tick += new EventHandler(ispaneltr);
            timer8.Tick += new EventHandler(notification);
            timer9.Tick += new EventHandler(pictr1);
            timer10.Tick += new EventHandler(pictr);
            timer11.Tick += new EventHandler(panelret2);
            timer12.Tick += new EventHandler(cirbar);
            timer88.Tick += new EventHandler(notificationBack);
            timer12.Interval = 5;
            timer11.Interval = 5;
            timer9.Interval = 5;
            timer10.Interval = 5;
            timer8.Interval = 5;
            timer88.Interval = 5;
            timer7.Interval = 5;
            timer6.Interval = 5;
            timer2.Interval = 5;
            timer3.Interval = 5;
            timer4.Interval = 5;
            timer5.Interval = 5;
            timerR.Start();
            timer1.Start();
            circularProgressBar2.Value = 0;
            circularProgressBar3.Value = 0;
            jMaterialTextbox4.Visible = false;
            jMaterialTextbox7.Visible = false;

        }

        void pictr(object sender, EventArgs e)
        {
            if (pictureBox15.Left <99)
            {
                pictureBox15.Left += 10;

            }
            if (pictureBox15.Left == 99)
            { pictureBox15.Visible = false; timer10.Stop(); timer9.Start(); }

        }
        void pictr1(object sender, EventArgs e)
        {
            // if (circularProgressBar2.Value < 60)
            // circularProgressBar2.Value += 30;
            circularProgressBar2.Value = 60;
            if (circularProgressBar2.Value == 60) timer9.Stop();

        }



        void cirbar(object sender, EventArgs e) { circularProgressBar3.Value = 60;  timer12.Stop(); }





        int ispanelspeed=3;
        void ispaneltr(object sender, EventArgs e)
        { if(isPanel2.Width< 70)
            isPanel2.Width += ispanelspeed;
            if (isPanel2.Width >= 71) timer7.Stop();
        }

        /*   public void Importforminpanel(object Xform)
           {
               if (this.visualPanel1.Controls.Count > 0) { this.visualPanel1.Controls.RemoveAt(0); }
               Form fc = Xform as Form;
               fc.TopLevel = false;
              // fc.Dock = DockStyle.Fill;
               this.visualPanel1.Controls.Add(fc);
               this.visualPanel1.Tag = fc;
               fc.Show();
           }*/


       
        int smooth = 2;
        int smoothy = 4;
        int panelmove = 55;

        void reg1()
        {
            
            if (visualSeparator2.Left > 8 )
            {

                visualSeparator2.Left -= smooth;
                visualSeparator3.Left -= smoothy;
                 panel5.Left -= panelmove;

                if (visualSeparator2.Left == 8)
                {
                    visualSeparator1.Left += 1;
                    timer4.Stop();
                }
            }
        }
        void log1()
        {
            if (visualSeparator2.Left < 18)
            {
                
                visualSeparator2.Left += smooth;
                visualSeparator3.Left += smoothy;
                panel5.Left += panelmove;
                
                if (visualSeparator2.Left == 18)
                {
                    visualSeparator1.Left -= 1;
                    timer5.Stop();
                }
            }
        }
        void timer4_go(object sender, EventArgs e)
        {
           // if (visualSeparator1.Left == 18)
                reg1();
          //  else if (visualSeparator1.Left == 19) log1();
        }
        void timer5_go(object sender, EventArgs e)
        {
            log1(); 
        }



        int panelspeed = 11;
        void paneltr(object sender, EventArgs e)
        {
            circularProgressBar3.Value = 0;
            if (panel3.Height < 429)
            {
                
                panel3.Height += panelspeed;
            }
            if(panel3.Height >= 429) { timer3.Stop(); timer12.Start(); }
           
        }

        void panelret(object sender, EventArgs e)
        {
            if (panel3.Height > 62)
            {
                panel3.Height -= panelspeed;
            }
            if (panel3.Height <= 62) { timer6.Stop(); timer8.Start(); }

        }
        void panelret2(object sender, EventArgs e)
        {
            if (panel3.Height > 62)
            {
                panel3.Height -= panelspeed;
            }
            if (panel3.Height <= 62) { timer11.Stop(); }
        }


        void notification(object sender, EventArgs e)
        {
            if (isPanel8.Left < -20)
                isPanel8.Left += 55;
            else { timer8.Stop(); timer10.Start(); }
        }
        void notificationBack(object sender, EventArgs e)
        {
            circularProgressBar2.Value = 0;
            pictureBox15.Left = 39;
            if (isPanel8.Left > -347)
                isPanel8.Left -= 55;
            else { timer88.Stop();}
        }

        void timer2_go(object sender, EventArgs e)
        {
            if (logreg.Text == "Get Started" || b1.Text== "→")
            {
                reg();
               
            }
            else if (logreg.Text == "label2")
            {
                log(); 
            }
        }
        int move_speed = 25;
        void reg()
        {
            if (panel2.Left > 0)
            {
                int move_speed1 = 10 ;
                if (panel2.Left < 500)
                {
                    panel1.Left -= move_speed;
                    panel2.Left -= move_speed;
                }
                else
                {
                    panel1.Left -= move_speed1;
                    panel2.Left -= move_speed1;
                }
                if (panel2.Left == 0)
                {
                    timer2.Stop();
                }
            }
        }
        void log()
        {
            if (panel1.Left < 0)
            {

                panel2.Left += move_speed;
                panel1.Left += move_speed;
                if (panel1.Left == 0)
                {
                    timer2.Stop();
                }
            }
        }

        private void Register(object sender, EventArgs e)
        {
            Label lr = (Label)sender;

            logreg = lr;
            timer2.Start();
        }
        private void Register1(object sender, EventArgs e)
        {
            Label lr = (Label)sender;

            logreg = lr;
            timer4.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cnx.da = new SqlDataAdapter("select *from voyageur", cnx.cn);
            cnx.da.Fill(db, "voyageur");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

           
        int r = 255;
        int g = 255;
        int b = 255;
       
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
         //   if (g >= 81)
         //   {
             //   if (r >= 65)
               //     r -= 3;
            //    if (b >= 139)
            //        b -= 4;
            //    g -= 2;

               //visualPanel1.BackColor = Color.FromArgb(r, g, b);
                //panel2.BackColor= Color.FromArgb(r, g, b);

              //  visualPanel1.BackColorState.Enabled = Color.FromArgb(r, g, b);
              //  visualPanel1.BackColorState.Disabled = Color.FromArgb(r, g, b);
                // textBox1.BackColor = Color.FromArgb(r, g, b);
             //   if (b <= 137 && r <= 64 && g <= 80)
               // {
                //    timerR.Stop();
                    //   timerG.Start();

                    // textBox1.Text = "hola";

              //  }
           // }
        }

        private void jThinButton4_Click(object sender, EventArgs e)
        {
            timer6.Start();
            isPanel5.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label47.Visible = false;
            label48.Visible = false;
            // timer3.Start();
            isPanel5.Visible = true;
            isPanel7.Visible = false;
            jMaterialTextbox4.Visible = false;
            jMaterialTextbox7.Visible = false;

           
                timer3.Start();
                
         

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void visualSeparator2_Click(object sender, EventArgs e)
        {
            if(visualSeparator1.Left == 18)
            timer4.Start();
            else if(visualSeparator1.Left ==19) timer5.Start();
        }

        private void visualSeparator3_Click(object sender, EventArgs e)
        {

            if (visualSeparator1.Left == 18)
                timer4.Start();
            else if (visualSeparator1.Left == 19) timer5.Start();
        }

        private void visualSeparator1_Click(object sender, EventArgs e)
        {
            if (visualSeparator1.Left == 18)
                timer4.Start();
            else if (visualSeparator1.Left == 19) timer5.Start();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (visualSeparator1.Left == 18)
                timer4.Start();
            else if (visualSeparator1.Left == 19) timer5.Start();
        }
        DateTime dt = new DateTime();
        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
               
                label9.Text = DateTime.Now.ToString("ss");
                label10.Text = DateTime.Now.ToString("hh:mm");
                label11.Text = DateTime.Now.ToString("dddd");
                label12.Text = DateTime.Now.ToString("dd/M/yyyy");
                circularProgressBar1.Value = Convert.ToInt32(label9.Text);

            }
            catch (Exception)
            {
                return;
            }


            String.Format("{0:y yy yyy yyyy}", dt);  // "8 08 008 2008"   year
            String.Format("{0:M MM MMM MMMM}", dt);  // "3 03 Mar March"  month
            String.Format("{0:d dd ddd dddd}", dt);  // "9 09 Sun Sunday" day
            String.Format("{0:h hh H HH}", dt);  // "4 04 16 16"      hour 12/24
            String.Format("{0:m mm}", dt);  // "5 05"            minute
            String.Format("{0:s ss}", dt);  // "7 07"            second
            String.Format("{0:f ff fff ffff}", dt);  // "1 12 123 1230"   sec.fraction
            String.Format("{0:F FF FFF FFFF}", dt);  // "1 12 123 123"    without zeroes
            String.Format("{0:t tt}", dt);  // "P PM"            A.M. or P.M.
            String.Format("{0:z zz zzz}", dt);  // "-6 -06 -06:00"   time zone
        }

        private void jThinButton2_Click(object sender, EventArgs e)
        {
            jThinButton1.BackgroundColor = ColorTranslator.FromHtml("#405089");
            jThinButton1.BorderColor = ColorTranslator.FromHtml("#405089");
            jThinButton2.BorderColor = ColorTranslator.FromHtml("#DC4576");
            jThinButton2.BackgroundColor = ColorTranslator.FromHtml("#FF5089");
        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            jThinButton2.BackgroundColor = ColorTranslator.FromHtml("#405089");
            jThinButton2.BorderColor = ColorTranslator.FromHtml("#405089");
            jThinButton1.BorderColor = ColorTranslator.FromHtml("#49CAFE");
            jThinButton1.BackgroundColor = ColorTranslator.FromHtml("#49CAFE");
        }
        public string value;

        private void isButton4_Click(object sender, EventArgs e)
        {
            if ((jMaterialTextbox1.Text == "De" || jMaterialTextbox1.Text == "") || (jMaterialTextbox1.Text != "Oujda" && jMaterialTextbox1.Text != "OUJDA" && jMaterialTextbox1.Text != "oujda"))
            {
                jMaterialTextbox1.ForeColor = ColorTranslator.FromHtml("#FC6572");
                isPanel11.ColorBottom = ColorTranslator.FromHtml("#FC6572");
                isPanel11.ColorTop = ColorTranslator.FromHtml("#FC6572");
                label42.Visible = true;
            }
            else if (jMaterialTextbox2.Text == "A" || jMaterialTextbox2.Text == "") //|| (jMaterialTextbox2.Text != "Oujda" && jMaterialTextbox1.Text != "OUJDA" && jMaterialTextbox1.Text != "oujda"))
            {
                jMaterialTextbox2.ForeColor = ColorTranslator.FromHtml("#FC6572");
                isPanel12.ColorBottom = ColorTranslator.FromHtml("#FC6572");
                isPanel12.ColorTop = ColorTranslator.FromHtml("#FC6572");
                label43.Visible = true;
            }
            else if(jMaterialTextbox4.Visible && jMaterialTextbox7.Visible)
            {
                if (jMaterialTextbox4.Text == "Num visa" || jMaterialTextbox4.Text == "")

                {
                    jMaterialTextbox4.ForeColor = ColorTranslator.FromHtml("#FC6572");
                   // jMaterialTextbox4.LineBackColor = ColorTranslator.FromHtml("#FC6572");
                    // isPanel12.ColorTop = ColorTranslator.FromHtml("#FC6572");
                    label47.Visible = true;
                }

               else if (jMaterialTextbox7.Text == "Jour de Visa" || jMaterialTextbox7.Text == "")
                {
                    jMaterialTextbox7.ForeColor = ColorTranslator.FromHtml("#FC6572");
                   // jMaterialTextbox7.LineBackColor = ColorTranslator.FromHtml("#FC6572");
                    // isPanel12.ColorTop = ColorTranslator.FromHtml("#FC6572");
                    label48.Visible = true;
                }
                else
                {
                    timer6.Start();
                    label33.Text = jMaterialTextbox1.Text;
                    label35.Text = jMaterialTextbox2.Text;
                }

            }
            
            else if (!jMaterialTextbox4.Visible && !jMaterialTextbox7.Visible)
            {
                 
                
                    timer6.Start();
                    label33.Text = jMaterialTextbox1.Text;
                    label35.Text = jMaterialTextbox2.Text;
            }
            try
            {
                cnx.cn.Open();
                SqlCommand commandselect = new SqlCommand("select id from VTV where date_D='" + visualComboBox1.Text + "'and ville_A = '" + jMaterialTextbox2.Text + "'", cnx.cn);
                SqlDataReader reader2 = commandselect.ExecuteReader();

                reader2.Read();
                string tabcptFTP;
                string varcmptFTP = reader2.GetString(0);


                tabcptFTP = reader2.GetString(0);//erreur 100% tester
                                                 // MessageBox.Show(tabcptFTP);
                string chaine = tabcptFTP;
                db.Tables["Voyageur"].Rows.Add(1, chaine);
                reader2.Close();
                //ntestew b3da hadi 3adi ndiro fo


                SqlDataAdapter _da = new SqlDataAdapter("select *from voyageur", cnx.cn);
                SqlCommandBuilder cb = new SqlCommandBuilder(_da);
                _da.Update(db.Tables["voyageur"]);
                SqlCommand commandselect2 = new SqlCommand("select count(*) from voyageur ", cnx.cn);
                SqlDataReader reader3 = commandselect2.ExecuteReader();
                reader3.Read();
                string a = reader3.GetInt32(0).ToString();
                value = (int.Parse(a) + 57).ToString(); ;
                //MessageBox.Show("count table voyageuur est :" + a);
                reader3.Close();
                cnx.cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Remplire tous les champs svp");
            }



        }
        public string getvalue() { return value; }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void isButton6_Click(object sender, EventArgs e)
        {
            b1.Text = isButton6.Contenue;
            timer2.Start();
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void visualSeparator11_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {
            b1.Text = isButton6.Contenue;
            timer2.Start();
            isPanel6.Visible = true;
            panel7.Visible = false;
            panel4.Visible = false;
            visualSeparator4.Visible = false;
            visualSeparator5.Visible = false;
            visualSeparator6.Visible = false;
            visualSeparator7.Visible = false;
        }

        private void label38_MouseHover(object sender, EventArgs e)
        {
            if (isPanel1.Width == 1)
                for (int i = 0; i < 55; i++) isPanel1.Width += 1;
        }

        private void label38_MouseLeave(object sender, EventArgs e)
        {
            // for (int i = 0; i < 27; i++) isPanel1.Width -= 2;
            isPanel1.Width = 1;
        }

        private void label37_MouseHover(object sender, EventArgs e)
        {
            for (int i = 0; i <35; i++) isPanel2.Width += 2;
        }

        private void label37_MouseLeave(object sender, EventArgs e)
        {
            isPanel2.Width = 1;
        }

        private void label36_MouseHover(object sender, EventArgs e)
        {
            for (int i = 0; i < 40; i++) isPanel3.Width += 2;
        }

        private void label36_MouseLeave(object sender, EventArgs e)
        {
            isPanel3.Width = 1;
        }

        private void label39_MouseHover(object sender, EventArgs e)
        {
           
            for (int i = 0; i < 50; i++) isPanel4.Width += 1;
        }

        private void label39_MouseLeave(object sender, EventArgs e)
        {
            isPanel4.Width = 1;
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void isButton1_Click(object sender, EventArgs e)
        {
            timer3.Start();
            isPanel5.Visible = true;
            isPanel7.Visible = false;
            jMaterialTextbox4.Visible = false;
            jMaterialTextbox7.Visible = false;
            jMaterialTextbox1.Text= "Oujda";
            jMaterialTextbox2.Text = label16.Text;
            jMaterialTextbox6.TextName = label19.Text;
        }

        private void button33_Click(object sender, EventArgs e)
        {
           
            jMaterialTextbox4.Visible = true;
            jMaterialTextbox7.Visible = true;
            isPanel7.Visible = true;
            isPanel5.Visible = false;
            isPanel13.Visible = true;
            isPanel14.Visible = true;
            timer3.Start();
            /* if(panel3.Height < 429)
            {
                timer3.Start();
            }
            else if (panel3.Height > 62)
            {
                timer11.Start();
            }*/
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process.Start("https://www.facebook.com/groups/ESTODAI/?ref=bookmarks");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCiYk7NeY5YrrBL5u0KhFuhA");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            timer11.Start();
            isPanel6.Visible = true;
            panel7.Visible = false;
            panel4.Visible = false;
            isPanel9.Visible = false;
            visualSeparator4.Visible = false;
            visualSeparator5.Visible = false;
            visualSeparator6.Visible = false;
            visualSeparator7.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            timer11.Start();
            panel7.Visible = true;
            isPanel6.Visible = false;
            panel4.Visible = false;
            isPanel9.Visible = false;
            visualSeparator4.Visible = false;
            visualSeparator5.Visible = false;
            visualSeparator6.Visible = false;
            visualSeparator7.Visible = false;
        }
           
        private void label4_Click(object sender, EventArgs e)
        {
            timer11.Start();
            panel7.Visible = false;
            isPanel6.Visible = false;
            panel4.Visible = true;
            isPanel9.Visible = false;
            visualSeparator4.Visible = true;
            visualSeparator5.Visible = true;
            visualSeparator6.Visible = true;
            visualSeparator7.Visible = true;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/ahmedouriarhi/?hl=fr");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 80; i++)
                label2.Width += 1;
        }

        private void isButton2_Click(object sender, EventArgs e)
        {
            timer3.Start();
            isPanel5.Visible = true;
            isPanel7.Visible = false;
            jMaterialTextbox4.Visible = false;
            jMaterialTextbox7.Visible = false;
            jMaterialTextbox1.Text = "Oujda";
            jMaterialTextbox2.Text = label23.Text;
            jMaterialTextbox6.TextName = label20.Text;
        }

        private void isButton3_Click(object sender, EventArgs e)
        {
            timer3.Start();
            isPanel5.Visible = true;
            isPanel7.Visible = false;
            jMaterialTextbox4.Visible = false;
            jMaterialTextbox7.Visible = false;
            jMaterialTextbox1.Text = "Oujda";
            jMaterialTextbox2.Text = label27.Text;
            jMaterialTextbox6.TextName = label24.Text;
        }

        private void isButton5_Click(object sender, EventArgs e)
        {
            timer3.Start();
            isPanel5.Visible = true;
            isPanel7.Visible = false;
            jMaterialTextbox4.Visible = false;
            jMaterialTextbox7.Visible = false;
            jMaterialTextbox1.Text = "Oujda";
            jMaterialTextbox2.Text = label31.Text;
            jMaterialTextbox6.TextName = label28.Text;
        }

        private void isPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {
            b1.Text = isButton6.Contenue;
            timer2.Start();
            isPanel6.Visible = true;
            panel7.Visible = false;
            panel4.Visible = false;
            visualSeparator4.Visible = false;
            visualSeparator5.Visible = false;
            visualSeparator6.Visible = false;
            visualSeparator7.Visible = false;

        }

        private void label36_Click(object sender, EventArgs e)
        {
            b1.Text = isButton6.Contenue;
            timer2.Start();
            isPanel6.Visible =false;
            panel7.Visible = true;
            panel4.Visible = false;
            visualSeparator4.Visible = false;
            visualSeparator5.Visible = false;
            visualSeparator6.Visible = false;
            visualSeparator7.Visible = false;
        }

        private void isPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label41_MouseHover(object sender, EventArgs e)
        {
            if (isPanel10.Width < 90)
            {
                for (int i = 0; i < 15; i++)
                {
                    isPanel10.Width += 6;
                }
            }
        }

        private void label41_Click(object sender, EventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {
            timer11.Start();
            panel7.Visible = false;
            isPanel6.Visible = false;
            panel4.Visible = false;
            isPanel9.Visible = true;
            visualSeparator4.Visible = false;
            visualSeparator5.Visible = false;
            visualSeparator6.Visible = false;
            visualSeparator7.Visible = false;
        }

        private void jMaterialTextbox1_Load(object sender, EventArgs e)
        {
            jMaterialTextbox1.ForeColor = ColorTranslator.FromHtml("#EFF0F3");
           // jMaterialTextbox1.LineBackColor = ColorTranslator.FromHtml("#EFF0F3");
        }

        private void jMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            jMaterialTextbox1.ForeColor = ColorTranslator.FromHtml("#EFF0F3");
           // jMaterialTextbox1.LineBackColor = ColorTranslator.FromHtml("#EFF0F3");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            jMaterialTextbox1.ForeColor = ColorTranslator.FromHtml("#EFF0F3");
            isPanel11.ColorBottom = ColorTranslator.FromHtml("#EFF0F3");
            isPanel11.ColorTop = ColorTranslator.FromHtml("#EFF0F3");
            label42.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void jMaterialTextbox2_TextChanged(object sender, EventArgs e)
        {
            jMaterialTextbox2.ForeColor = ColorTranslator.FromHtml("#EFF0F3");
            isPanel12.ColorBottom = ColorTranslator.FromHtml("#EFF0F3");
            isPanel12.ColorTop = ColorTranslator.FromHtml("#EFF0F3");
            label43.Visible = false;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
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

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            timer11.Start();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void jMaterialTextbox4_TextChanged(object sender, EventArgs e)
        {
            jMaterialTextbox4.ForeColor = ColorTranslator.FromHtml("#EFF0F3");
            //isPanel12.ColorBottom = ColorTranslator.FromHtml("#EFF0F3");
           // isPanel12.ColorTop = ColorTranslator.FromHtml("#EFF0F3");
            label47.Visible = false;
        }

        private void jMaterialTextbox7_TextChanged(object sender, EventArgs e)
        {
            jMaterialTextbox7.ForeColor = ColorTranslator.FromHtml("#EFF0F3");
          //  isPanel12.ColorBottom = ColorTranslator.FromHtml("#EFF0F3");
          //  isPanel12.ColorTop = ColorTranslator.FromHtml("#EFF0F3");
            label48.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            timer3.Start();
            isPanel5.Visible = true;
            isPanel7.Visible = false;
            isPanel13.Visible = true;
            isPanel14.Visible = true;
            jMaterialTextbox4.Visible = true;
            jMaterialTextbox7.Visible = true;
            jMaterialTextbox1.Text = "Oujda";
            jMaterialTextbox2.Text = "Paris";
            jMaterialTextbox6.TextName = label19.Text;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer3.Start();
            isPanel5.Visible = true;
            isPanel7.Visible = false;
            jMaterialTextbox4.Visible = false;
            jMaterialTextbox7.Visible = false;
            jMaterialTextbox1.Text = "Oujda";
            jMaterialTextbox2.Text = "Casablanca";
            jMaterialTextbox6.TextName = label19.Text;

        }

        private void isButton8_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
            visualComboBox1.Items.Clear();
           
                SqlCommand cmd = new SqlCommand("select * from V_trajet where ville_A = '" + jMaterialTextbox2.Text + "'", cnx.cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "V_trajet");
           
           

            foreach (DataRow x in ds.Tables["V_trajet"].Rows) { visualComboBox1.Items.Add(x[4].ToString()); jMaterialTextbox6.TextName = x[3].ToString()+ "DH"; }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Remplire tous les champs svp");
            }
        }

        private void isButton7_Click(object sender, EventArgs e)
        {
            Contact cnt = new Contact(this);
            cnt.Show();
            timer88.Start();

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
