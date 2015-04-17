using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Cinema
{
    public class Controller
    {
        private Film film;
        private Salle salle;
        private Home main_form;
        private projections projection;
        private loading loading_screen; 
        public projections Projections
        {
            get { return projection; }
            set { projection = value; }
        }


        public Controller()
        {
            loading_screen = new loading();
            main_form = new Home(this);
            film = new Film(this);
            salle = new Salle(this);
            projection = new projections(this);
            film.GetFilm();
            salle.ImportFromCSV("dbSalles.csv");
            Application.Run(main_form);
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


        public void load_projections()
        {
           Thread t = new Thread(this.Projections.load_films);
           t.Name = "proj_loader";
           t.Start();
        }

        public bool check_film_date(string film_title,string date)
        {
            return projection.check_film_date(film_title, date);
        }

        public string[] get_film_sceances(string p,string date)
        {
            return projection.get_film_sceances(p,date);
        }

        public SalleItem get_salle(string id)
        {
            return salle.get_salle(Convert.ToInt32(id));
        }

        public void save_salle()
        {
            this.salle.SaveSalle();
        }


        public void show_loading_screen(int total_number)
        {
            object[] parameters = new object[] { total_number };
            loading.show show_frm = new loading.show(loading_screen.show_frm);
            loading_screen.Invoke(show_frm,parameters);
            loading_screen.Show();
        }

        public void loading_created_proj()
        {
            loading_screen.add();
        }
    }
}
