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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        private void jMetroTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void taskLabel4_Click(object sender, EventArgs e)
        {

        }

        private void jThinButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string x = textBox1.Text;
                int tmp = cnx.search("Vehicule", x);
                if (tmp == 1)
                {
                    MessageBox.Show("Vehicule déja existe !!!!");
                }
                else
                {


                    ds.Tables["Vehicule"].Rows.Add(textBox1.Text, jMetroTextBox1.TextName, Convert.ToInt32(jMetroTextBox2.TextName).ToString(), jMetroTextBox3.TextName, jMetroTextBox4.TextName);
                    MessageBox.Show("Ajout avec Succés");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
        //achbanlik ma3reftch chnu w9e3 ok kml ok

        private void jThinButton4_Click(object sender, EventArgs e)
        {
            try
            {
                string x = textBox1.Text;
                int tmp = cnx.search("Vehicule", x);
                if (tmp == 1)
                {
                    string req = string.Format("Update Vehicule set  Categorie='{1}',Nbr_places ='{2}',Carte_grise ='{3}',Proprietaire ='{4}' where Id ='{0}'", textBox1.Text, jMetroTextBox1.TextName, Convert.ToInt32(jMetroTextBox2.TextName).ToString(), jMetroTextBox3.TextName, jMetroTextBox4.TextName);
                    SqlCommand cmd = new SqlCommand(req, cnx.cn);
                    cnx.cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("modification valide");
                    cnx.cn.Close();

                }
                else
                {
                    MessageBox.Show("Vehicule n'existe pas !!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            cnx.da = new SqlDataAdapter("select *from Vehicule", cnx.cn);
            cnx.da.Fill(ds, "Vehicule");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter _da = new SqlDataAdapter("select *from Vehicule", cnx.cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(_da);
            _da.Update(ds.Tables["Vehicule"]);
            MessageBox.Show("Enregistrements valide");
        }

        private void jThinButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string x = textBox1.Text;
                int tmp = cnx.search("Vehicule", x);
                if (tmp == 1)
                {
                    string req = string.Format("Delete from Vehicule where Id= '" + textBox1.Text + "'");
                    SqlCommand cmd = new SqlCommand(req, cnx.cn);
                    cnx.cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("suppression valide");
                    cnx.cn.Close();

                }
                else
                {
                    MessageBox.Show("Vehicule n'existe pas !!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int founded = cnx.search("Vehicule", textBox1.Text);
            if (founded == 1)
            {
                for (int i = 0; i < ds.Tables["Vehicule"].Rows.Count; i++)
                {
                    if (ds.Tables["Vehicule"].Rows[i][0].ToString() == textBox1.Text)
                    {
                        jMetroTextBox1.TextName = ds.Tables["Vehicule"].Rows[i][1].ToString();
                        jMetroTextBox2.TextName = ds.Tables["Vehicule"].Rows[i][2].ToString();
                        jMetroTextBox3.TextName = ds.Tables["Vehicule"].Rows[i][3].ToString();

                        jMetroTextBox4.TextName = ds.Tables["Vehicule"].Rows[i][4].ToString();
                       
                        //10 vitesssss sssf dbrj3 l archive dir datagrid jdida w 3tiha archive v
                       


                    }
                }
            }
            else
            {
                jMetroTextBox2.TextName = "";
                jMetroTextBox3.TextName = "";
                jMetroTextBox4.TextName = "";
                jMetroTextBox1.TextName = "";
            }
        }
    }
}
