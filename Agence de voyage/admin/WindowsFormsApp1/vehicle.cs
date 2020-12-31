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
    public partial class vehicle : Form
    {
        public vehicle()
        {
            InitializeComponent();
        }

        private void vehicle_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'istravelDataSet7.Vehicule'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vehiculeTableAdapter1.Fill(this.istravelDataSet7.Vehicule);
            // TODO: cette ligne de code charge les données dans la table 'istravelDataSet6.Vehicule'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vehiculeTableAdapter.Fill(this.istravelDataSet6.Vehicule);
            // TODO: cette ligne de code charge les données dans la table 'istravelDataSet5.V_Vehicule'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.v_VehiculeTableAdapter.Fill(this.istravelDataSet5.V_Vehicule);

        }
    }
}
