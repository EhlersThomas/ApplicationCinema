using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cinema
{
    public class Controller
    {
        private Film film;
        private Salle salle;

        public Controller()
        {
            film = new Film(this);
            salle = new Salle(this);
            film.GetFilm();

            Application.Run(new Home(this));
        }
        #region Importation des données
        public void ImportFilmsFromCSV()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            string filename = "";

            if (result == DialogResult.OK)
            {
                filename = ofd.FileName;
                film.ImportFromCSV(filename);
                film.SaveFilm();
                film.GetFilm();
            }
        }
        public void ImportSallesFromCSV()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            string filename = "";

            if (result == DialogResult.OK)
            {
                filename = ofd.FileName;
                salle.ImportFromCSV(filename);
                salle.SaveSalle();
            }
        }
        #endregion 
        

    
        public List<FilmItem> get_films_items()
        {
            return film.List_film;
        }
        
    }
}
