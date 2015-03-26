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

        public Home(Controller ctrl)
        {
            InitializeComponent();
            this.ctrl = ctrl;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialisation du dateTimePicker à la date du jour
            dateTimePicker1.Value = DateTime.Now;

            #region Importation des données
            foreach (FilmItem f in ctrl.get_films_items())
            {
                cbxFilms.Items.Add(f.titre);
            }
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
    }
}
