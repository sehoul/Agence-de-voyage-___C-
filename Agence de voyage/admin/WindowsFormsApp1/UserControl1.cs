using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            if (this.jThinButton1.ButtonText == "Homme")
            {
                this.jThinButton1.ButtonText = "Femme";
                this.jThinButton1.BorderColor = ColorTranslator.FromHtml("#F83D94");
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
    }
}
