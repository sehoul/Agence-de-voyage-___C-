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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();


        private void Form10_Load(object sender, EventArgs e)
        {
            cnx.da = new SqlDataAdapter("select *from Trajet", cnx.cn);
            cnx.da.Fill(ds, "Trajet");
        }

        private void jThinButton3_Click_1(object sender, EventArgs e)
        {
            try
            {
                string x = textBox1.Text;
                int tmp = cnx.search("Trajet", x);
                if (tmp == 1)
                {
                    MessageBox.Show("Trajet déja existe !!!!");
                }
                else
                {


                    ds.Tables["Trajet"].Rows.Add(textBox1.Text, jMetroTextBox2.TextName, jMetroTextBox3.TextName, Convert.ToInt32(jMetroTextBox4.TextName).ToString(), Convert.ToInt32(jMetroTextBox5.TextName).ToString());
                    MessageBox.Show("Ajout avec Succés");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter _da = new SqlDataAdapter("select *from Trajet", cnx.cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(_da);
            _da.Update(ds.Tables["Trajet"]);
            MessageBox.Show("Enregistrements valide");
        }

        private void jThinButton4_Click(object sender, EventArgs e)
        {
            try
            {
                string x = textBox1.Text;
                int tmp = cnx.search("Trajet", x);
                if (tmp == 1)
                {
                    string req = string.Format("Update Trajet set ville_D='{1}',ville_A ='{2}',Km ='{3}',prix ='{4}' where Id ='{0}'", textBox1.Text, jMetroTextBox2.TextName, jMetroTextBox3.TextName, Convert.ToInt32(jMetroTextBox4.TextName).ToString(), Convert.ToInt32(jMetroTextBox5.TextName).ToString());
                    SqlCommand cmd = new SqlCommand(req, cnx.cn);
                    cnx.cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("modification valide");
                    cnx.cn.Close();

                }
                else
                {
                    MessageBox.Show("Trajet n'existe pas !!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void jThinButton2_Click(object sender, EventArgs e)
        {
            try
            {// for(int i = 0; i < ds.Tables["Trajet"].Rows.Count; i++)
             // {
             //    if (ds.Tables["Trajet"].Rows[i][0].ToString()== textBox1.Text)
             //  {
             //     ds.Tables["Trajet"].Rows[i].Delete();
             //      MessageBox.Show("suppression valide");
             //  }

                //  }

                string x = textBox1.Text;
                int tmp = cnx.search("Trajet", x);
                if (tmp == 1)
                {
                    string req = string.Format("Delete from Trajet where Id= '" + textBox1.Text + "'");
                    SqlCommand cmd = new SqlCommand(req, cnx.cn);
                    cnx.cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("suppression valide");
                    cnx.cn.Close();

                }
                else
                {
                    MessageBox.Show("Trajet n'existe pas !!!");
                }
            }
            catch (Exception ex)
            {
             //   MessageBox.Show(ex.Message);
            }

        }

        private void jMetroTextBox1_Load(object sender, EventArgs e)
        {
            int founded = cnx.search("Trajet", textBox1.Text);
            if (founded == 1)
            {
                for (int i = 0; i < ds.Tables["Trajet"].Rows.Count; i++)
                {
                    if (ds.Tables["Trajet"].Rows[i][0].ToString() == textBox1.Text)
                    {

                        jMetroTextBox2.TextName = ds.Tables["Trajet"].Rows[i][1].ToString();
                        jMetroTextBox3.TextName = ds.Tables["Trajet"].Rows[i][2].ToString();

                        jMetroTextBox4.TextName = ds.Tables["Trajet"].Rows[i][3].ToString();
                        jMetroTextBox5.TextName = ds.Tables["Trajet"].Rows[i][4].ToString();



                    }
                }
            }
            else
            {
                jMetroTextBox2.TextName = "";
                jMetroTextBox3.TextName = "";
                jMetroTextBox4.TextName = "";
                jMetroTextBox5.TextName = "";
            }
        }

   
    }
    
}
