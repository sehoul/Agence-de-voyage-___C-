using System;
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
    public partial class trajetuser : Form
    {
        public trajetuser()
        {
            InitializeComponent();
        }

        private void trajetuser_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'istravelDataSet4.Trajet'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.trajetTableAdapter.Fill(this.istravelDataSet4.Trajet);

        }
    }
}
