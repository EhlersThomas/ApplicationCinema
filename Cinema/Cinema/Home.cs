/*  Author: Thomas Ehlers IFA-P3B
 *  Date: 12.03.2015
 *  Version: 1.0
 *  Description: Main page from the application, import data from files
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Cinema
{
    public partial class Home : Form
    {
        Controller ctrl;
        public SalleItem actual_room;
        public projections.projection actual_projection;

        public Home(Controller ctrl)
        {
            InitializeComponent();
            this.ctrl = ctrl;
            
        }

        private List<Panel> seats = new List<Panel>();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialisation du dateTimePicker à la date du jour
            dateTimePicker1.Value = DateTime.Now;

            #region Importation des données
            foreach (FilmItem f in ctrl.get_films_items())
            {
                cbxFilms.Items.Add(f.titre);
            }

            ctrl.load_projections();
            #endregion 
        }
        //Lorsque l'on clique sur le bouton on importe les films
        private void importerFilmsDunFichierCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctrl.ImportFilmsFromCSV();
        }
        //Lorsque l'on clique sur le bouton on importe les salles
        private void ajouterUneSalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctrl.ImportSallesFromCSV();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (cbxSceance.Enabled)
                pnl_salle.Controls.Clear();
            cbxSceance.Enabled = false;
            cbxSceance.Items.Clear();
            btnValider.Enabled = false;
            if (ctrl.check_film_date(cbxFilms.Text,dateTimePicker1.Value.ToString("dd/MM/yyyy")))
            {
                cbxSceance.Items.AddRange(ctrl.get_film_sceances(cbxFilms.Text, dateTimePicker1.Value.ToString("dd/MM/yyyy")));
                cbxSceance.Enabled = true;
            }
        }

        private void visionerProjectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new projections_affichage(ctrl).Show();
        }

        private void cbxFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxSceance.Items.Clear();
            cbxSceance.Enabled = false;
            pnl_salle.Controls.Clear();
            dateTimePicker1.Enabled = true;
            btnValider.Enabled = false;
        }

        private void cbxSceance_SelectedIndexChanged(object sender, EventArgs e)
        {
            projections.projection p = ctrl.Projections.get_projection(cbxFilms.Text, dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            this.actual_room = p.get_salle(cbxSceance.Text);
            this.actual_projection = p;
            show_salle(this.actual_room);
            btnValider.Enabled = true;
        }

        private void show_salle(SalleItem s)
        {
            pnl_salle.Controls.Clear();
            foreach (SiegeItem si in s.list_siege)
            {
                Panel p = new Panel();
                p.Parent = pnl_salle;
                p.Height = 15;
                p.Width = 15;
                p.Name = si.id.ToString();
                p.Click += p_Click;
                if (si.free)
                    p.BackColor = Color.Green;
                else
                    p.BackColor = Color.Red;
                Point pos = new Point(si.rang * 20 + 1, si.no * 20 + 1);
                p.Location = pos;
            }
        }

        private void p_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Panel).Name);
            this.actual_room.change_siege_state(id,false);
            (sender as Panel).BackColor = Color.Red;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            projections.save_salles(this.actual_room,this.actual_projection.id,cbxSceance.Text.Replace(":",""));
        }

        
    }
}
