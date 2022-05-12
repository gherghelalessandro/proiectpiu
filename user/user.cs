using System;
using carte;
using biblioteca;
using System.IO;

namespace user
{
    public class user
    {
        int nrcarti_de_imprumutat;
        Carte[] carti;
        int i = 0;
        static int id=0;
        string nume, prenume,email,parola;
        string descriere;

        public user(string numeuser)
        {
            
            carti = new Carte[nrcarti_de_imprumutat];
            id++;
            Stream fisiertext = File.Open(numeuser, FileMode.OpenOrCreate);
            fisiertext.Close();
            using (StreamReader streamreadFisierText = new StreamReader(numeuser))
            {

                string linieFisier;
                linieFisier = streamreadFisierText.ReadLine();
                nrcarti_de_imprumutat = int.Parse(linieFisier);
                while ((linieFisier = streamreadFisierText.ReadLine()) != null)
                {
                    carti[i] = carti[i].citirefile(linieFisier);
                    i++;
                }

            }
        }
        public user()
        {
            nrcarti_de_imprumutat = 0;
        }

        public void borrow_book(string numecarte,string numeautor,string numeeditura, Biblioteca b)
        {
            if (i > nrcarti_de_imprumutat)
            {
                Console.WriteLine("Ai depasit nr de carti de imprumutat");
            }
            else
            {
                carti[i] = b.getbook(numecarte,numeautor,numeeditura);
                if (carti[i] == null)
                {
                    Console.WriteLine("cartea nu exista");

                }
                else if(carti[i].nr<0)
                {
                    Console.WriteLine("cartea s-a terminat");
                }
                else
                {
                    i++;
                    b.editare_carte(carti[i].nume, carti[i].autor, carti[i].editura,-1);
                }

            }


        }
        public void return_book(string numecarte,string numeautor,string numeeditura, Biblioteca b)
        {
            carti[i] = b.getbook(numecarte, numeautor, numeeditura);
            if (carti[i] == null)
            {
                Console.WriteLine("cartea nu exista");
            }
            else
            {
               carti[i] = new Carte();
               i--;
               b.editare_carte(carti[i].nume, carti[i].autor, carti[i].editura, 1);
            }

            
        }

    }
}
