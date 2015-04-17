using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class projections_affichage : Form
    {
        private Controller _ctrl;
        public projections_affichage(Controller ctrl)
        {
            this._ctrl = ctrl;
            InitializeComponent();
        }

        private void projections_affichage_Load(object sender, EventArgs e)
        {
            foreach (projections.projection p in this._ctrl.Projections.List_rojections)
            {
                string heures = "";
                foreach (string time in p.Heure)
                {
                    heures += time + "|";
                }

                lsb_projections.Items.Add(p.Date + " - " + p.film.titre + " (salle " + p.sales[0].id + ") " + heures);
            }
        }
    }
}
