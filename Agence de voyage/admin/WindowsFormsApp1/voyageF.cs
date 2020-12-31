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
    public partial class voyageF : Form
    {
        public voyageF()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        private void jThinButton3_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            int tmp = cnx.search("Voyage", x);
            if (tmp == 1)
            {
                MessageBox.Show("L'Voyage déja existe !!!!");
            }
            else
            {

                ds.Tables["Voyage"].Rows.Add(textBox1.Text, jMetroTextBox2.TextName, jMetroTextBox3.TextName, jMetroTextBox7.TextName, metroDateTime2.Value.ToString(), jThinButton1.ButtonText);

                MessageBox.Show("Ajout avec Succés");           }
        }

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
                               
            }
            else
            {

                this.jThinButton1.ButtonText = "International";
                this.jThinButton1.BorderColor = ColorTranslator.FromHtml("#FF883B");
                this.jThinButton1.HoverBorder = ColorTranslator.FromHtml("#33B1BF");
                this.jThinButton1.ForeColors = ColorTranslator.FromHtml("#FF883B");
                this.jThinButton1.HoverFontColor = ColorTranslator.FromHtml("#33B1BF");
            }
        }

        private void voyageF_Load(object sender, EventArgs e)
        {
            cnx.da = new SqlDataAdapter("select *from Voyage", cnx.cn);
            cnx.da.Fill(ds, "Voyage");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter _da = new SqlDataAdapter("select *from Voyage", cnx.cn);
                SqlCommandBuilder cb = new SqlCommandBuilder(_da);
                _da.Update(ds.Tables["Voyage"]);
                MessageBox.Show("Enregistrements valide");
            }
            catch(Exception ep)
            {
               // MessageBox.Show(ep.Message);
            }
        }

        private void jThinButton4_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            int tmp = cnx.search("Voyage", x);
            if (tmp == 1)
            {
                string req = string.Format("Update Voyage set Id_trajet ='{1}',Id_Employee ='{2}',Id_Vehicule ='{3}',date_D ='{4}',Type_V ='{5}' where Id ='{0}'", textBox1.Text, jMetroTextBox2.TextName, jMetroTextBox3.TextName, jMetroTextBox7.TextName, metroDateTime2.Value.ToString(),jThinButton1.ButtonText);
                SqlCommand cmd = new SqlCommand(req, cnx.cn);
                 cnx.cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("modification valide");
                cnx.cn.Close();

            }
            else
            {
                MessageBox.Show("Voyage n'existe pas !!!");
            }
        }

        private void jThinButton2_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            int tmp = cnx.search("Voyage", x);
            if (tmp == 1)
            {
                string req = string.Format("Delete from Voyage where Id= '" + textBox1.Text + "'");
                SqlCommand cmd = new SqlCommand(req, cnx.cn);
                cnx.cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("suppression valide");
                cnx.cn.Close();
                jMetroTextBox2.TextName = "";
                jMetroTextBox3.TextName = "";
                jMetroTextBox7.TextName = "";
                metroDateTime2.Value = DateTime.Now;
                textBox1.Text = "";
                
            }
            else
            {
                MessageBox.Show("Voyage n'existe pas !!!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int founded = cnx.search("Voyage", textBox1.Text);
            if (founded == 1)
            {
                for (int i = 0; i < ds.Tables["Voyage"].Rows.Count; i++)
                {
                    if (ds.Tables["Voyage"].Rows[i][0].ToString() == textBox1.Text)
                    {

                        jMetroTextBox2.TextName = ds.Tables["Voyage"].Rows[i][1].ToString();

                        jMetroTextBox3.TextName = ds.Tables["Voyage"].Rows[i][2].ToString();

                        metroDateTime2.Value = DateTime.Parse(ds.Tables["Voyage"].Rows[i][4].ToString());

                       

                        jMetroTextBox7.TextName = ds.Tables["Voyage"].Rows[i][3].ToString();

                        if (ds.Tables["Voyage"].Rows[i][5].ToString() == "National")
                        {
                                this.jThinButton1.ButtonText = "National";
                                this.jThinButton1.BorderColor = ColorTranslator.FromHtml("#33B1BF");
                                this.jThinButton1.HoverBorder = ColorTranslator.FromHtml("#FF883B");
                                this.jThinButton1.ForeColors = ColorTranslator.FromHtml("#33B1BF");
                                this.jThinButton1.BackColor = ColorTranslator.FromHtml("#304753");
                                this.jThinButton1.HoverFontColor = ColorTranslator.FromHtml("#FF883B");

                        }
                            else
                            {
                         
                                this.jThinButton1.ButtonText = "International";
                                this.jThinButton1.BorderColor = ColorTranslator.FromHtml("#FF883B");
                                this.jThinButton1.HoverBorder = ColorTranslator.FromHtml("#33B1BF");
                                this.jThinButton1.ForeColors = ColorTranslator.FromHtml("#FF883B");
                                this.jThinButton1.HoverFontColor = ColorTranslator.FromHtml("#33B1BF");
                            }


                        }
                }
            }
            else
            {
                jMetroTextBox2.TextName = "";
                jMetroTextBox3.TextName = "";                
                metroDateTime2.Value = DateTime.Now;
                jMetroTextBox7.TextName = "";
                
                


            }
        }
    }
}
