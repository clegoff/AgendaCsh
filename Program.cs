using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    static class Program
    {
        static String path = System.IO.Directory.GetParent(System.IO.Directory.GetParent(
                                System.IO.Path.GetDirectoryName(Application.ExecutablePath)).FullName).FullName + "\\data\\ids.xml";
        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/

            Compte c1 = new Compte(0, "Cedric", "Legoff", "0111111111", "", "c.legoffpro@gmail.com", "", "123", new Calendrier(), new List<Compte>());
            Compte c2 = new Compte(0, "Oceane", "Delafond", "0222222222", "", "oc@gmail.com", "", "1234", new Calendrier(), new List<Compte>());
            Compte c3 = new Compte(0, "Laura", "Lesdema", "0333333333", "", "la@gmail.com", "", "456", new Calendrier(), new List<Compte>());
            List<Compte> listCompte = new List<Compte>();
            listCompte.Add(c1);
            listCompte.Add(c2);
            listCompte.Add(c3);
            WriteXML(listCompte);
        }


        public static void WriteXML(List<Compte> myList)
        {
            System.IO.FileStream file = null;
            try {
                System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Compte>));
                file = System.IO.File.Create(path);
                //Console.WriteLine(file.Name);

                writer.Serialize(file, myList);
                file.Close();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

        }

        public static void ReadXML()
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Compte>));
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            List<Compte> comptes = (List<Compte>)reader.Deserialize(file);
            file.Close();

            foreach (Compte c in comptes)
            {
                Console.WriteLine(c.ToString());
            }
        }

    }
}
