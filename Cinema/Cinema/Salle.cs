using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.ComponentModel;

namespace Cinema
{
    public struct SalleItem
    {
        public int id;
        public List<SiegeItem> list_siege;
        public SiegeItem get_siege(int id)
        {
            for (int i = 0; i < list_siege.Count; i++ )
            {
                if (list_siege[i].id == id)
                    return list_siege[i];
            }
            SiegeItem x = new SiegeItem();
            x.id = -1;
            return x;
            
        }


        internal void change_siege_state(int id, bool p)
        {
            for (int i = 0; i < list_siege.Count; i++)
            {
                if (list_siege[i].id == id)
                {
                    SiegeItem s = list_siege[i];
                    s.free = false;
                    list_siege[i] = s;
                }
            }
        }
    };
    public struct SiegeItem
    {
        public int id;
        public int rang;
        public int no;
        public bool free;
    };
    class Salle
    {
        private Controller controller;
        private List<SalleItem> list_salle;

        public List<SalleItem> List_salle
        {
            get { return list_salle; }
            set { list_salle = value; }
        }
         
        string xml_filename = "dbSalles.xml";
        public Salle(Controller controller)
        {
            this.controller = controller;
            list_salle = new List<SalleItem>();
        }

        public void ImportFromCSV(string filename)
        {            
            //Ouverture du stream reader
            string line;
            StreamReader fichierSalles = new StreamReader(filename);

            // SalleItem pour stocker le film avant de l'insérer dans la liste
            SalleItem item;

            #region A utiliser uniquement si plus de données que le no de salle
            //Si il y a plus de données il faut également modifier le code d'extraction
            //Création d'un tableau temporaire pour classer les données
            string[] line_data = new string[3];
            
            #endregion

            //Tant que la ligne lue n'est pas vide
            while ((line = fichierSalles.ReadLine()) != null)
            {
                line_data = line.Split(',');

                item.id = Convert.ToInt32(line_data[0]);
                item.list_siege = AjouterSiege(Convert.ToInt32(line_data[1]), Convert.ToInt32(line_data[2]));
                list_salle.Add(item);
            }

            //Fermeture du stream reader
            fichierSalles.Close();
        }

        public void SaveSalle()
        {
            
            XmlSerializer serializer = new XmlSerializer(typeof(List<SalleItem>));
            StreamWriter stream_writer = new StreamWriter(xml_filename);

            serializer.Serialize(stream_writer, list_salle);
            stream_writer.Close();
        }
        public List<SiegeItem> AjouterSiege(int nbRang, int nbSiege)
        {
            List<SiegeItem> l = new List<SiegeItem>();
            int rang = 1;
            int no = 1;
            SiegeItem siege;
            int totalSiege = nbRang * nbSiege;
            for(int i = 0; i <= totalSiege - 1; i++)
            {
                siege.id = i + 1;
                siege.no = no;
                siege.rang = rang;
                siege.free = true;
                if(no == nbSiege)
                {
                    rang++;
                    no = 0;
                }
                
                l.Add(siege);
                no++;
            }
            return l;
        }

        //Get the data in dbSalles.xml
        public void GetFilm()
        {
            if (File.Exists(xml_filename))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<SalleItem>));
                StreamReader file = new StreamReader(xml_filename);
                list_salle = (List<SalleItem>)serializer.Deserialize(file);
                file.Close();
            }
        }

        public SalleItem get_salle(int id)
        {
            foreach(SalleItem s in List_salle)
            {
                if (s.id == id)
                    return s;
            }
            SalleItem si = new SalleItem();
            si.id = -1;
            return si;
        }
    }
}
