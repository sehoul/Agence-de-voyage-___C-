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

namespace WindowsFormsApp6
{
    public partial class Contact : Form
    {
        Timer timer1 = new Timer();
        Timer timer2 = new Timer();
        Timer timer3 = new Timer();
        Timer timer4 = new Timer();
        DataSet ds = new DataSet();
        public Contact(Form1 tk)
        {
            InitializeComponent();
          //  timer1.Tick += new EventHandler(pictr);
            timer1.Interval = 5;
           // timer2.Tick += new EventHandler(pictr1);
            timer2.Interval = 5;
          //  timer3.Tick += new EventHandler(pictr2);
            timer3.Interval = 5;
          //  timer4.Tick += new EventHandler(pictr3);
            timer4.Interval = 5;
            cnx.da = new SqlDataAdapter("select *from voy", cnx.cn);
            cnx.da.Fill(ds, "voy");
            Form1 href = tk;
            label6.Text = href.getvalue();
            int founded = cnx.search4("voy", href.getvalue());
            if (founded == 1)
            {
                for (int i = 0; i < ds.Tables["voy"].Rows.Count; i++)
                {
                    if (ds.Tables["voy"].Rows[i][0].ToString() == href.getvalue())
                    {

                        label4.Text = ds.Tables["voy"].Rows[i][1].ToString();
                        label3.Text = ds.Tables["voy"].Rows[i][2].ToString();
                        label2.Text = ds.Tables["voy"].Rows[i][3].ToString();
                        label5.Text = ds.Tables["voy"].Rows[i][4].ToString() + "DH";
                        label7.Text = ds.Tables["voy"].Rows[i][5].ToString();
                        label1.Text = ds.Tables["voy"].Rows[i][6].ToString();
                    }
                }
            }
        }
        
        private void isButton1_Click(object sender, EventArgs e)
        {

        }
        private void Contact_Load(object sender, EventArgs e)
        {           
            //timer1.Start() ;
        }

        Bitmap bmp;
        private void isButton7_Click(object sender, EventArgs e)
        {

            isButton7.Visible = false;
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
            //MessageBox.Show("inis");
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
