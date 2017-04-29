using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosovacList
{
    class Losovac
    {
        private List<int> cisla;
        private Random random;

        public Losovac()
        {
            random = new Random();
            cisla = new List<int>();

        }

        public int Losuj()
        {
            int cislo = random.Next(100)+1;
            cisla.Add(cislo);
            return cislo;
        }

        public string Vypis()
        {
            string s = "";
            cisla.Sort();
            foreach (int i in cisla)
                s += i + " ";
            return s;
        }


        public double Prumer()
        {
            double p = cisla.Average();
            return p;
        }

       

        
    }
}
