using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carte
{
    public class Carte
    {
        private const char separator_fisier= ';';

        public int idcarte { get; set; }
        public string nume { get; set; }
        public string autor { get; set; }
        public string editura { get; set; }
        public int nr { get; set; }

        public Carte()
        {
            idcarte = 0;
            nume = autor = editura = string.Empty;
            nr = 0;
        }
        public Carte(string _nume,string _autor,string _editura,int _nr)
        {
            this.nume = _nume;
            this.autor = _autor;
            this.editura = _editura;
            this.nr = _nr;
        }
        public Carte(string liniefile)
        {
            string[] datas = liniefile.Split(separator_fisier);
            idcarte = Convert.ToInt32(datas[0]);
            nume = datas[1];
            autor = datas[2];
            editura = datas[3];
            nr = Convert.ToInt32(datas[4]);
            
        }
        public string conversiontostring()
        {
            string convertor = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}"
                ,separator_fisier,idcarte.ToString(),nume,autor,editura,nr.ToString());
            return convertor;
        }
        public bool valideazastring(string s)
        {

            char[] c=s.ToCharArray();
            for(int i=0;i<c.Length;i++)
            {
                if(c[i] >= 48 && c[i] <= 57 || c[i] >= 65 && c[i] <= 90 || c[i] >= 97 && c[i] <= 122)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
