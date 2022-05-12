using System;
using carte;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace biblioteca
{
    public class Biblioteca
    {

        Carte c = new Carte();
        public LinkedList<Carte> c1 = new LinkedList<Carte>();
        string numefisier;
        int index;
        
     
        //constructori
        public Biblioteca()
        {

        }

        public Biblioteca(string numefile)
        {
            numefisier = numefile;
            Stream fisiertext = File.Open(numefile, FileMode.OpenOrCreate);
            fisiertext.Close();
            using (StreamReader streamreadFisierText = new StreamReader(numefile))
            {
                string linieFisier;
                
                while ((linieFisier = streamreadFisierText.ReadLine()) != null)
                {
                    c = c.citirefile(linieFisier);
                    if (getbook(c.nume,c.autor,c.editura) == null)
                    {
                        c1.AddLast(c);
                    }

                }

            }

        }

        //functii de editare a bibliotecii

        //adaugare
        public void add_carte(Carte c)
        {
            if (getbook(c.nume,c.autor,c.editura) == null&&(c.nume!=string.Empty&&c.autor!=string.Empty&&c.editura!=string.Empty&&c.nr!=0))
            {
                c.id++;
                index = c.id;
                c1.AddLast(c);
            }
        }

        public void addbooks_tofile(Biblioteca b)
        {
            Stream fisiertext = File.Open(numefisier, FileMode.OpenOrCreate);
            fisiertext.Close();
            using (StreamWriter s = new StreamWriter(numefisier, true))
            {
                
                foreach (Carte carte in b.c1)
                {
                    index += b.index;
                    if (getbook(carte.nume,carte.autor,carte.editura)==null)
                    {
                        
                        s.WriteLine(index+";"+carte.nr + ";" + carte.nume + ";" + carte.autor + ";" + carte.editura + ";");
                        c1.AddLast(carte);
                        index++;
                    }
                    

                }

            }
        }

        //stergere
        public void remove_carte(string numecarte,string numeautor,string numeeditura)
        {
            if (getbook(numecarte, numeautor, numeeditura) == null)
            {
                Console.WriteLine("Carte inexistenta sau deja scoasa");
            }
            else
            { 
                c1.Remove(getbook(numecarte, numeautor, numeeditura));
                index--;
            }

        }

        

        //editare propriu zisa
        public void editare_carte(string numecarte,string numeautor,string numeeditura,int da)
        {
            string optiuni = "";
            Carte aux = getbook(numecarte,numeautor,numeeditura);
            if (aux == null)
            {
                Console.WriteLine("Nu se poate edita cartea pt ca nu exista");
            }
            else if(da==0)
            {
                while (optiuni != "x")
                {
                    Console.Clear();
                    Console.WriteLine("Optiuni cartea {0} de editat", aux.nume);
                    Console.WriteLine("Add-adaugare nr carti\n" +
                                       "Editnume-editare numele cartii\n" +
                                       "Editautor-editare numele autorului\n" +
                                       "Editeditura-editare numele edituri\n" +
                                       "X-iesire din menu optiuni");
                    optiuni = Console.ReadLine();
                    optiuni = optiuni.ToLower();
                    string s;
                    switch (optiuni)
                    {
                        case "add":
                            Console.WriteLine("Cate carti vrei sau adaugi");
                            int n;
                            n = int.Parse(Console.ReadLine());
                            aux.nr = aux.nr + n;
                            break;
                        case "editnume":

                            Console.WriteLine("Noul nume al carti este:");
                            s = Console.ReadLine();
                            aux.nume = s;
                            break;
                        case "editautor":
                            Console.WriteLine("Noul nume al autorului este:");
                            s = Console.ReadLine();
                            aux.autor = s;
                            break;
                        case "editeditura":
                            Console.WriteLine("Noua editura este:");
                            s = Console.ReadLine();
                            aux.editura = s;
                            break;

                        case "x":

                            break;
                        default:
                            Console.WriteLine("optiune nu exista");
                            break;
                    }
                }
            }
            else if(da==1)
            {
                aux.nr++;
                editare_nrcarti(aux);
                
            }    
            else if(da==-1)
            {
                if(aux.nr>0)
                {
                    aux.nr--;
                    editare_nrcarti(aux);
                }
                else
                {
                    Console.WriteLine("putine carti");
                }
                
            }
            
        }

        void editare_nrcarti(Carte carte)
        {
            int i = 0;
            string[] line = File.ReadAllLines(numefisier);
            foreach(string s in line)
            {
                
                Carte c=new Carte();
                c=c.citirefile(s);
                Console.WriteLine(c.nume);
                if(c.nume==carte.nume&&c.autor==carte.autor&&c.editura==carte.editura)
                {
                    c.nr--;
                    string newline = c.id + ";" +c.nr+";"+c.nume+";"+c.autor+";"+c.editura+";";
                    line[i] = newline;
                    break;
                }
                i++;
            }
            foreach(string s in line)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
            File.WriteAllLines(numefisier,line);
        }

        //cauta carte din biblioteca
        public Carte getbook(string numecarte,string numeautor,string numeeditura)
        {
            foreach (Carte c in c1)
            {
                
                if (c.nume.ToLower().Trim() == numecarte.ToLower().Trim()&&
                    c.autor.ToLower().Trim()==numeautor.ToLower().Trim()&&
                    c.editura.ToLower().Trim()==numeeditura.ToLower().Trim())
                {
                    return c;
                }
            }
            return null;

        }

        
        public Carte[] getnumecarte(string numecarte)
        {
            Carte[] listanume=new Carte[30];
            int nr = 0;
            foreach (Carte c in c1)
            {
                if(c.nume.Trim().ToLower()==numecarte.Trim().ToLower())
                {
                    listanume[nr++] = c;
                }
            }
            return listanume;
        }

        //functii de afisarea datelor
       
        //din biblioteca
        public void afisare_biblioteca()
        {
            Console.WriteLine("Lista de carti disponibile");
            foreach (Carte c in c1)
            {
                c.afisaredate();
            }
        }
        //din fisier text
        public void afis_carte_fromfile()
        {
            Stream fisiertext = File.Open(numefisier, FileMode.OpenOrCreate);
            fisiertext.Close();
            using (StreamReader streamreadFisierText = new StreamReader(numefisier))
            {
                string linieFisier;

                while ((linieFisier = streamreadFisierText.ReadLine()) != null)
                {
                    c = c.citirefile(linieFisier);
                    c.afisaredate();
                }

            }
        }


        


    }
}
