using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carte;
using bazadedatetxt;

namespace proiectpiu
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin_books t = new Admin_books("fisier.txt");
            
            Console.ReadKey();
        }
    }
}
