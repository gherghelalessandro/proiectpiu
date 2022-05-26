using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carte;
using user;
using System.IO;

namespace bazadedatetxt
{
    public class Admin_books
    {
        private const int id_prim = 1;
        private const int increment = 1;
        private string numefile;

        public Admin_books(string numeFisier)
        {
            numefile = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }
        public void addcarte(Carte c)
        {
            Carte aux = this.GetCarte(c.nume, c.autor, c.editura);
            if(aux==null)
            {
                c.idcarte = GetId();
                using (StreamWriter streamWriterFisierText = new StreamWriter(numefile, true))
                {
                    streamWriterFisierText.WriteLine(c.conversiontostring());
                }
            }
            else
            {
                Console.WriteLine("cartea a fost deja pusa");
            }
            
        }

        public void removecarte(Carte c)
        {
            Carte aux = this.GetCarte(c.nume, c.autor, c.editura);
            string tempFile = Path.GetTempFileName();
            using (var sr = new StreamReader(numefile))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    Carte carte = new Carte(line);
                    carte.idcarte = GetId();
                    if(aux.nume!=carte.nume||aux.autor!=carte.autor||carte.editura!=aux.editura)
                    {
                        sw.WriteLine(line);
                    }
                }
            }
            File.Delete(numefile);
            File.Move(tempFile, numefile);
        }
        public List<Carte> getbooks()
        {
            ArrayList carti=new ArrayList();
            using (StreamReader streamReader = new StreamReader(numefile))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Carte c = new Carte(linieFisier);
                    carti.Add(c);
                }
            }
            return carti.Cast<Carte>().ToList();
        }
        public Carte GetCarte(string nume,string autor,string editura)
        {
            using (StreamReader streamReader = new StreamReader(numefile))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Carte carte = new Carte(linieFisier);
                    if (carte.nume.Equals(nume) && carte.autor.Equals(autor)&&carte.editura.Equals(editura))
                        return carte;
                }
            }
            return null;
        }
        public Carte GetCarte(int id)
        {
            using (StreamReader streamReader = new StreamReader(numefile))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Carte carte = new Carte(linieFisier);
                    if (carte.idcarte==id)
                        return carte;
                }
            }
            return null;
        }
        public bool updateCarte(Carte c)
        {
            List<Carte> carti = getbooks();
            bool actualizareCuSucces = false;

            //instructiunea 'using' va apela la final swFisierText.Close();
            //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numefile, false))
            {
                foreach (Carte carte in carti)
                {
                    Carte cartedeup = carte;
                    
                    if (c.idcarte == carte.idcarte)
                    {
                        cartedeup = c;
                    }
                    streamWriterFisierText.WriteLine(cartedeup.conversiontostring());
                }
                actualizareCuSucces = true;
            }

            return actualizareCuSucces;
        }
        public void borrow_return_book(Carte c,bool predare)
        {
            c = GetCarte(c.nume, c.autor, c.editura);
            if (c == null)
            {
                Console.WriteLine("cartea nu exista");
                
            }
            if (c.nr == 0&&predare==false)
            { 
                Console.WriteLine("cartea s-a terminat");
            }
            else
            {
                if(predare==false)
                {
                    c.nr--; 
                    Console.WriteLine("cartea a fost imprumutata");
                }
                else
                {
                    c.nr++;
                    Console.WriteLine("cartea a fost returnata");
                }  
                this.updateCarte(c);
            }   
        }
        private int GetId()
        {
            int Idcarte = id_prim;
            using (StreamReader streamReader = new StreamReader(numefile))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Carte C= new Carte(linieFisier);
                    Idcarte = C.idcarte + increment;
                }
            }

            return Idcarte;
        }
    }
}
