using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.ComponentModel;

namespace Cinema
{
    public struct FilmItem
    {
        public int id;
        public string titre;
        
        [XmlIgnore]
        public TimeSpan duree;
        
        [Browsable(false)]
        [XmlElement(DataType = "duration", ElementName = "Duree")]
        public string DureeString
        {
            get
            {
                return XmlConvert.ToString(duree);
            }
            set
            {
                duree = string.IsNullOrEmpty(value) ?
                    TimeSpan.Zero : XmlConvert.ToTimeSpan(value);
            }
        }
    };

    class Film
    {
        private Controller controller;
        private List<FilmItem> list_film;

        public List<FilmItem> List_film
        {
            get { return list_film; }
            set { list_film = value; }
        }
        //Name of XML file
        string xml_filename = "dbFilms.xml";

        public Film(Controller controller)
        {
            this.controller = controller;
            list_film = new List<FilmItem>();
        }

        public void ImportFromCSV(string filename)
        {
            list_film.Clear();
            //Ouverture du stream reader
            string ligne;
            StreamReader fichierFilms = new StreamReader(filename);

            // FilmItem pour stocker le film avant de l'inserer dans la liste
            FilmItem item;

            //Création d'un tableau temporaire pour classer les données
            string[] line_data = new string[3];
            string titre;
            
            //Tant que la ligne lue n'est pas vide
            while ((ligne = fichierFilms.ReadLine()) != null)
            {
                //on la sépare par champs dans un tableau
                line_data = ligne.Split(',');

                item.id = Convert.ToInt32(line_data[0]);
                titre = line_data[1];

                //On enlève les éventuels guimellets
                if (titre[0] == '"')
                    titre = titre.Substring(1, titre.Length - 2);

                item.titre = titre;
                item.duree = TimeSpan.Parse(line_data[2]);

                list_film.Add(item);
            }

            //Fermeture du stream reader
            fichierFilms.Close();
            GetFilm();
        }

        public void SaveFilm()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<FilmItem>));
            StreamWriter stream_writer = new StreamWriter(xml_filename);

            serializer.Serialize(stream_writer, list_film);
            stream_writer.Close();
        }


        //Get the data in dbFilms.xml
        public void GetFilm()
        {
            if (File.Exists(xml_filename))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<FilmItem>));
                StreamReader file = new StreamReader(xml_filename);
                list_film = (List<FilmItem>)serializer.Deserialize(file);
                file.Close();
            }
        }
    }
}
