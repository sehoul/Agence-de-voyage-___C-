﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AboutAS : Form
    {
        public string lng;
        public AboutAS(Form2 frm)
        {
           
            InitializeComponent();
            Form2 fr = frm;
            lng = fr.Lng();
                        

        }

       public void visualLabel2_Click(object sender, EventArgs e)
        {
           
        }

        private void AboutAS_Load(object sender, EventArgs e)
        {
                    
        }

        private void visualDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}