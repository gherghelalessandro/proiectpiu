using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biblioteca;
using System.Media;
using carte;

namespace proba1
{
    class Program
    {
        static void Main(string[] args)
        {

            Biblioteca c = new Biblioteca("proba.txt");
            Biblioteca datedeactualizat = new Biblioteca();
            Carte carte;
            string optiuni, numecarte,numeautor,numeeditura;
            


            do
            {
                Console.Clear();
                Console.WriteLine("Meniu de la biblioteca\n" +
                                  "\n------------------------------------\n" +
                                  "Add-adaugare carte\n" +
                                  "savefile-salvare biblioteca\n" +
                                  "readfromfile-afisare din fisier\n" +
                                  "Remove-scoatere carte\n" +
                                  "Edit-editare carte\n" +
                                  "Afis-afisare biblioteca\n" +
                                  "Exit-iesire din aplicatie\n" +
                                  "---------------------------------------\n");
                optiuni = Console.ReadLine();
                optiuni = optiuni.ToLower();

                switch (optiuni)
                {
                    case "add":
                        string nr, sir, sir2, sir3;
                        int x;
                        Console.WriteLine("Numele cartii:");
                        sir = Console.ReadLine();
                        Console.WriteLine("Autorul cartii");
                        sir2 = Console.ReadLine();
                        Console.WriteLine("Editura cartii");
                        sir3 = Console.ReadLine();
                        Console.WriteLine("nr de exemplare");
                        nr = Console.ReadLine();
                        while(int.TryParse(nr, out x) == false)
                        {
                            Console.WriteLine("atentie nr este incorect te rog sa reintroduci:");
                            nr = Console.ReadLine();
                        }
                        carte = new Carte(int.Parse(nr),sir,sir2,sir3);
                        datedeactualizat.add_carte(carte);
                        break;
                    case "remove":
                        Console.WriteLine("Ce carte vrei sa scoti");
                        numecarte = Console.ReadLine();
                        Console.WriteLine("Autor:");
                        numeautor = Console.ReadLine();
                        Console.WriteLine("Editura");
                        numeeditura = Console.ReadLine();
                        c.remove_carte(numecarte, numeautor,numeeditura);
                        break;
                    case "edit":
                        Console.WriteLine("Ce carte vrei sa editi");
                        numecarte = Console.ReadLine();
                        Console.WriteLine("Autor:");
                        numeautor = Console.ReadLine();
                        Console.WriteLine("Editura");
                        numeeditura = Console.ReadLine();
                        c.editare_carte(numecarte,numeautor,numeeditura,-1);
                        break;
                    case "savefile":
                        c.addbooks_tofile(datedeactualizat);
                        break;
                    
                    case "readfromfile":
                        c.afis_carte_fromfile();
                        Console.ReadKey();
                        break;
                    case "afis":
                        c.afisare_biblioteca();
                        Console.ReadKey();
                        break;
                    case "search":
                        string nume;
                        nume=Console.ReadLine();
                        foreach(Carte ca in c.getnumecarte(nume))
                        {
                            if (ca == null)
                                break;
                            Console.WriteLine(ca.nume + " " + ca.autor + " " + ca.editura + " \n");
                        }
                        Console.ReadKey();
                        break;
                    case "play":
                        SoundPlayer s = new SoundPlayer();
                        s.SoundLocation = @"C:\Users\Kryss\source\repos\proba1\mm.wav";
                        s.Play();
                        break;
                    case "date":
                        string timp = DateTime.Now.ToString("d");
                        Console.WriteLine(timp);
                        Console.ReadKey();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Nope");
                        Console.ReadKey();
                        break;
                }
            } while (optiuni != "exit");


        }
    }
}
