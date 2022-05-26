using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carte;

namespace user
{
    public class user1
    {
        public int id { get; set; }
        public string nume { get; set; }
        public string parola { get; set; }
        public int[] id_de_cartiimprumutate;
        int nrmax = 3;
        int index = 0;
        
        user1()
        {
            id = 0;
            nume = "";
            parola = "";
            id_de_cartiimprumutate = new int[3];
        }
        user1(string nume, string parola)
        {
            this.nume = nume;
            this.parola = parola;
        }
        user1(string liniefile)
        {
            string[] datas = liniefile.Split(';');
            id = Convert.ToInt32(datas[0]);
            nume = datas[1];
            parola = datas[2];
            index = Convert.ToInt32(datas[3]);
            for(int i=0;i<index;i++)
            {

            }
        }
        public bool updateid(int idcarte)
        {
            if(index>=3)
            {
                Console.WriteLine("ai depasit limita te rog sa returnezi cartea");
                return false;
            }
            else
            {
                id_de_cartiimprumutate[index++] = idcarte;
                return true;
            }
        }
        public bool returnid(int idcarte)
        {
            for(int i=0;i<nrmax;i++)
            {
                if(id_de_cartiimprumutate[i]==idcarte)
                {
                    id_de_cartiimprumutate[i] = 0;
                    return true;
                }
            }
            return false;
        }



    }
}
