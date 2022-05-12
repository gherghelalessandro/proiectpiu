using System;

namespace carte
{

    public class Carte

    {
        public int nr { get;set; }
        public string nume { get; set; }
        public string autor { get; set; }
        public string editura { get; set; }

        public int id;

        public Carte()
        {
            id = 0;
            nr = 0;
            nume = " ";
            autor = " ";
            editura = " ";

        }
        public Carte(int n, string _nume, string _autor, string _editura)
        {
            
            nr = n;
            nume = _nume;
            autor = _autor;
            editura = _editura;
        }
        public Carte citirefile(string liniedefile)
        {
            var aux = liniedefile.Split(';');
            Carte c = new Carte();
            id = Convert.ToInt32(aux[0]);
            
            c.nr = Convert.ToInt32(aux[1]);
            c.nume = aux[2];
            
            c.autor = aux[3];
            c.editura = aux[4];
            return c;
        }
        public void afisaredate()
        {
            Console.WriteLine("id:"+id+" Cartea:" + nume + " de " + autor + " Editura:" + editura + "-" + nr);
        }
    }
}
