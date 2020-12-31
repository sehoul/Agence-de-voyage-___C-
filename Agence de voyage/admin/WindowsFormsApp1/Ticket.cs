using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class Ticket : Form
    {
        public Ticket() 
        {
            InitializeComponent();
            visualComboBox3.Text = "1";
        }
       
        private void Ticket_Load(object sender, EventArgs e)
        {
            this.trajetTableAdapter.Fill(this.istravelDataSet3.Trajet);
           
        }

        public string value;
        private void jThinButton1_Click(object sender, EventArgs e)
        {
            if (this.jThinButton1.ButtonText == "International")
            {
                this.jThinButton1.ButtonText = "National";
                this.jThinButton1.BorderColor = ColorTranslator.FromHtml("#33B1BF");
                this.jThinButton1.HoverBorder = ColorTranslator.FromHtml("#FF883B");
                this.jThinButton1.ForeColors = ColorTranslator.FromHtml("#33B1BF");
                this.jThinButton1.BackColor = ColorTranslator.FromHtml("#304753");
                this.jThinButton1.HoverFontColor = ColorTranslator.FromHtml("#FF883B");
                jMetroTextBox3.Visible = false;
                jMetroTextBox4.Visible = false;
                taskLabel7.Visible = false;
                taskLabel8.Visible = false;

            }
            else
            {

                this.jThinButton1.ButtonText = "International";
                this.jThinButton1.BorderColor = ColorTranslator.FromHtml("#FF883B");
                this.jThinButton1.HoverBorder = ColorTranslator.FromHtml("#33B1BF");
                this.jThinButton1.ForeColors = ColorTranslator.FromHtml("#FF883B");
                this.jThinButton1.HoverFontColor = ColorTranslator.FromHtml("#33B1BF");
                jMetroTextBox3.Visible = true;
                jMetroTextBox4.Visible = true;
                taskLabel7.Visible = true;
                taskLabel8.Visible = true;
            }
        }

        private void jThinButton3_Click(object sender, EventArgs e)
        {
            DataSet db = new DataSet();
            cnx.da = new SqlDataAdapter("select *from voyageur", cnx.cn);
            cnx.da.Fill(db, "voyageur");
            cnx.cn.Open();
            SqlCommand commandselect = new SqlCommand("select id from VTV where date_D='" + visualComboBox4.Text + "'and ville_A = '" + visualComboBox1.Text + "'", cnx.cn);
            SqlDataReader reader2 = commandselect.ExecuteReader();
           
            reader2.Read();
            string tabcptFTP;
            string varcmptFTP = reader2.GetString(0).ToString();
         

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
            value = (int.Parse(a) + 57).ToString();
            MessageBox.Show("maintenant vous pouvez imprimer le ticket");
            reader3.Close();
            cnx.cn.Close();
        }
        public string getvalue()
        {
            return value;

        }

        private void visualComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void isButton1_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            visualComboBox4.Items.Clear();
           
            SqlCommand cmd = new SqlCommand("select * from V_trajet where ville_A = '" + visualComboBox1.Text + "'",cnx.cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "V_trajet");
           
            
            foreach(DataRow x in ds.Tables["V_trajet"].Rows) { visualComboBox4.Items.Add(x[4].ToString());  jMetroTextBox8.TextName = (float.Parse(x[3].ToString()) * (float.Parse(visualComboBox3.Text))).ToString()+"DH";  }
                    


        }

        private void visualComboBox1_Click(object sender, EventArgs e)
        {
            
          
        }

        private void isButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void jMetroTextBox8_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void isButton2_Click_1(object sender, EventArgs e)
        {
            ticketimp tki = new ticketimp(this);
            tki.Show();
           

        }
    }
}
