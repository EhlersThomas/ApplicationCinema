using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cinema
{
    public class projections
    {
        private Controller ctrl;
        private List<projection> list_projections;
        public List<projection> List_rojections
        {
            get { return list_projections; }
            set { list_projections = value; }
        }

        public projections(Controller ctrl)
        {
            this.ctrl = ctrl;
            this.List_rojections = new List<projection>();
        }

        public struct projection
        {
            public int id;
            public FilmItem film;
            private DateTime date;
            private string[] heure;
            public List<SalleItem> sales;
            public string Date
            {
                get { return date.ToString("dd/MM/yyyy"); }
                set { date = DateTime.Parse(value); }
            }
            
            public string[] Heure
            {
                get { return heure; }
                set { heure = value; }
            }

            internal SalleItem get_salle(string time)
            {
                for (int i = 0; i < heure.Length; i++)
                {
                    if (heure[i] == time)
                        return sales[i];
                }
                return new SalleItem();
            }
        };

        public void load_films()
        {
            // Structure de projections.txt
            // id projection;id film;titre film;date projection;heure 1/heure 2/heure 3/...;id salle
            // format date : jj/mm/aaaa - format heure : hh:mm/hh:mm/hh:mm/hh:mm
            ctrl.show_loading_screen(File.ReadAllLines("projections.txt").Count()); 

            using (var s = new StreamReader("projections.txt"))
            {
                string line;
                while ((line = s.ReadLine()) != null)
                {
                    string[] proj = line.Split(';');
                    foreach (FilmItem f in this.ctrl.get_films_items())
                    {
                        if (proj[1] == f.id.ToString())
                        {

                            int status = 0;
                            projection p = new projection();
                            p.film = f;
                            p.id = Convert.ToInt32(proj[0]);
                            p.Date = proj[3];
                            p.Heure = proj[4].Split('/');
                            p.sales = get_salles(proj[5],p.Heure,p.id, ref status);
                            if (status == 1)
                            {
                                for(int i = 0; i < p.sales.Count; i++)
                                {
                                    save_salles(p.sales[i],p.id,p.Heure[i].Replace(":",""));
                                }
                            }
                            this.List_rojections.Add(p);
                            this.ctrl.loading_created_proj();
                        }
                    }
                }
            }
        }

        private List<SalleItem> get_salles(string salle_id, string[] times, int id, ref int _status)
        {
            List<SalleItem> s;
            _status = 0;



            s = new List<SalleItem>();
            for (int i = 0; i < times.Length; i++)
            {
                if (File.Exists("projections_salles\\projections_" + id + "_" + times[i].ToString().Replace(":", "") + ".proj_salle"))
                {
                    StreamReader stream = new StreamReader("projections_salles\\projections_" + id + "_" + times[i].ToString().Replace(":", "") + ".proj_salle");
                    System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(SalleItem));
                    s.Add((SalleItem)serializer.Deserialize(stream));
                    stream.Close();
                    serializer = null;
                }
                else
                {
                    s.Add(ctrl.get_salle(salle_id));
                    _status = 1;
                }

            }

            return s;
        }

        public static void save_salles(SalleItem l, int id,string proj_time)
        {
            StreamWriter stream = new StreamWriter("projections_salles\\projections_" + id + "_" + proj_time + ".proj_salle");
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(SalleItem));
            serializer.Serialize(stream, l);
            stream.Close();
            serializer = null;
        }


        public projection get_projection(string film_title)
        {
            foreach (projection p in this.List_rojections)
            {
                if (p.film.titre == film_title)
                    return p;
            }

            projection pr = new projection();
            pr.film.id = -1;

            return pr;
        }

        public projection get_projection(string film_title,string date)
        {
            foreach (projection p in this.List_rojections)
            {
                if (p.film.titre == film_title && p.Date == date)
                    return p;
            }

            projection pr = new projection();
            pr.film.id = -1;

            return pr;
        }

        public List<projection> get_projections(string film_title)
        {
            List<projection> list_proj = new List<projection>(); ;
            foreach (projection p in this.List_rojections)
            {
                if (p.film.titre == film_title)
                    list_proj.Add(p);
            }
            return list_proj;
        }

        public string[] get_film_sceances(string film_title,string date)
        {
            return get_projection(film_title,date).Heure;

        }

        public bool check_film_date(string film_title, string date)
        {
            bool valid = false;
            List<projection> p = get_projections(film_title);
            foreach (projection p_item in p)
            {
                if (p_item.film.id != -1 && p_item.Date == date)
                    valid = true;
            }
            return valid;
        }
    }
}
