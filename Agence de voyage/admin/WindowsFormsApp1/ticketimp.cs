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
using System.Data;

namespace WindowsFormsApp1
{
    public partial class ticketimp : Form
    {
        DataSet ds = new DataSet();
        Bitmap bmp;
        
        public ticketimp(Ticket tk)
        {
            InitializeComponent();
            cnx.da = new SqlDataAdapter("select *from voy", cnx.cn);
            cnx.da.Fill(ds, "voy");
            Ticket href = tk;
            label6.Text = href.getvalue();
            int founded = cnx.search4("voy",label6.Text);
            if (founded == 1)
            {
                for (int i = 0; i < ds.Tables["voy"].Rows.Count; i++)
                {
                    if (ds.Tables["voy"].Rows[i][0].ToString() == label6.Text)
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

        private void ticketimp_Load(object sender, EventArgs e)
        {
          
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void isButton2_Click(object sender, EventArgs e)
        {
            isButton2.Visible = false;
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
            //MessageBox.Show("inis");
            this.Close();
        }
    }
}

