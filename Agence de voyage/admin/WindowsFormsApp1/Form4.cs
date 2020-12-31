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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        private void jMetroTextBox5_Load(object sender, EventArgs e)
        {

        }

        private void visualLabel1_Click(object sender, EventArgs e)
        {

        }

        private void jMetroTextBox8_Load(object sender, EventArgs e)
        {

        }

        private void visualLabel6_Click(object sender, EventArgs e)
        {

        }

        private void visualLabel4_Click(object sender, EventArgs e)
        {

        }

        private void visualLabel10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {

        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            if (this.jThinButton1.ButtonText == "Homme")
            {
                this.jThinButton1.ButtonText = "Femme";
                this.jThinButton1.BorderColor= ColorTranslator.FromHtml("#F83D94");
               this.jThinButton1.HoverBorder = ColorTranslator.FromHtml("#FFFFFF");
                this.jThinButton1.ForeColors = ColorTranslator.FromHtml("#F83D94");
                this.jThinButton1.HoverBackground = ColorTranslator.FromHtml("#F83D94");


            }
            else
            {

                this.jThinButton1.ButtonText = "Homme";
                this.jThinButton1.BorderColor = ColorTranslator.FromHtml("#39B6BC");
                this.jThinButton1.HoverBorder = ColorTranslator.FromHtml("#FFFFFF");
                this.jThinButton1.ForeColors = ColorTranslator.FromHtml("#39B6BC");
                this.jThinButton1.HoverBackground = ColorTranslator.FromHtml("#39B6BC");
            }
        }

        private void jMetroTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void jThinButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string x = textBox1.Text;
                int tmp = cnx.search2("Employes", x);
                if (tmp == 1)
                {
                    MessageBox.Show("L'employe déja existe !!!!");
                }
                else
                {

                    ds.Tables["Employes"].Rows.Add(textBox1.Text, jMetroTextBox2.TextName, jMetroTextBox3.TextName, metroDateTime2.Value.ToString(), jMetroTextBox8.TextName, jMetroTextBox7.TextName, jMetroTextBox6.TextName, visualRichTextBox1.Text, metroDateTime1.Value.ToString(), jThinButton1.ButtonText);

                    MessageBox.Show("Ajout avec Succés");
                    cnx.cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void Form4_Load(object sender, EventArgs e)
        {
            cnx.da = new SqlDataAdapter("select *from Employes", cnx.cn);
            cnx.da.Fill(ds, "Employes");
        }

        private void metroDateTime2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter _da = new SqlDataAdapter("select *from Employes", cnx.cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(_da);
            _da.Update(ds.Tables["Employes"]);
            MessageBox.Show("Enregistrements valide");
            cnx.cn.Close();
        }

        private void jThinButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string x = textBox1.Text;
                int tmp = cnx.search2("Employes", x);
                if (tmp == 1)
                {
                    string req = string.Format("Delete from Employes where Matricule= '" + textBox1.Text + "'");
                    SqlCommand cmd = new SqlCommand(req, cnx.cn);
                    cnx.cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("suppression valide");
                    cnx.cn.Close();
                    jMetroTextBox2.TextName = "";
                    jMetroTextBox3.TextName = "";
                    jMetroTextBox8.TextName = "";
                    metroDateTime2.Value = DateTime.Now;
                    jMetroTextBox6.TextName = "";
                    jMetroTextBox7.TextName = "";
                    metroDateTime1.Value = DateTime.Now;
                    visualRichTextBox1.Text = "";
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Employes n'existe pas !!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void jThinButton4_Click(object sender, EventArgs e)
        {
            try
            {
                string x = textBox1.Text;
                int tmp = cnx.search2("Employes", x);
                if (tmp == 1)
                {
                    string req = string.Format("Update Employes set Nom ='{1}',Prenom ='{2}',Date_N ='{3}',Fonction ='{4}',Email ='{5}',Tel ='{6}' ,Adresse ='{7}' ,Date_E ='{8}',Sexe ='{9}' where Matricule ='{0}'", textBox1.Text, jMetroTextBox2.TextName, jMetroTextBox3.TextName, metroDateTime2.Value.ToString(), jMetroTextBox8.TextName, jMetroTextBox7.TextName, jMetroTextBox6.TextName, visualRichTextBox1.Text, metroDateTime1.Value.ToString(), jThinButton1.ButtonText);
                    SqlCommand cmd = new SqlCommand(req, cnx.cn);
                    cnx.cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("modification valide");
                    cnx.cn.Close();

                }
                else
                {
                    MessageBox.Show("Employes n'existe pas !!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int founded = cnx.search2("Employes", textBox1.Text);
            if (founded == 1)
            {
                for (int i = 0; i < ds.Tables["Employes"].Rows.Count; i++)
                {
                    if (ds.Tables["Employes"].Rows[i][0].ToString() == textBox1.Text)
                    {

                        jMetroTextBox2.TextName = ds.Tables["Employes"].Rows[i][1].ToString();

                        jMetroTextBox3.TextName = ds.Tables["Employes"].Rows[i][2].ToString();

                        metroDateTime2.Value = DateTime.Parse(ds.Tables["Employes"].Rows[i][3].ToString());

                        jMetroTextBox8.TextName = ds.Tables["Employes"].Rows[i][4].ToString();

                        jMetroTextBox7.TextName = ds.Tables["Employes"].Rows[i][5].ToString();

                        jMetroTextBox6.TextName = ds.Tables["Employes"].Rows[i][6].ToString();

                        visualRichTextBox1.Text = ds.Tables["Employes"].Rows[i][7].ToString();

                        metroDateTime1.Value = DateTime.Parse(ds.Tables["Employes"].Rows[i][8].ToString());

                        if (ds.Tables["Employes"].Rows[i][9].ToString() == "Homme")
                        {
                            this.jThinButton1.ButtonText = "Homme";

                            this.jThinButton1.BorderColor = ColorTranslator.FromHtml("#39B6BC");
                            this.jThinButton1.HoverBorder = ColorTranslator.FromHtml("#FFFFFF");
                            this.jThinButton1.ForeColors = ColorTranslator.FromHtml("#39B6BC");
                            this.jThinButton1.HoverBackground = ColorTranslator.FromHtml("#39B6BC");
                        }
                        else
                        {
                            this.jThinButton1.ButtonText = "Femme";

                            this.jThinButton1.BorderColor = ColorTranslator.FromHtml("#F83D94");
                            this.jThinButton1.HoverBorder = ColorTranslator.FromHtml("#FFFFFF");
                            this.jThinButton1.ForeColors = ColorTranslator.FromHtml("#F83D94");
                            this.jThinButton1.HoverBackground = ColorTranslator.FromHtml("#F83D94");
                        }


                    }
                }
            }
            else
            {
                jMetroTextBox2.TextName = "";
                jMetroTextBox3.TextName = "";
                jMetroTextBox8.TextName = "";
                metroDateTime2.Value = DateTime.Now;
                jMetroTextBox6.TextName = "";
                jMetroTextBox7.TextName = "";
                metroDateTime1.Value = DateTime.Now;
                visualRichTextBox1.Text = "";

            }
        }
    }
}
