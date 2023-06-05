using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20230525_utasszalito
{
    class Típus
        {
        public string tipus, utas, személyzet;
        public int év, utazósebesség, felszállótömeg;
        public double fesztav;
        public Típus(string egysor)
        {
            string[] darabok = egysor.Split(';');
            tipus = darabok[0];
            év = int.Parse(darabok[1]);
            utas = darabok[2];
            személyzet = darabok[3];
            utazósebesség = int.Parse(darabok[4]);
            felszállótömeg = int.Parse(darabok[5]);
            fesztav = double.Parse(darabok[6]);
        }
    }
    class Sebessegkategoria
    {
        private int Utazosebesseg;
        public string Kategorianev
        {
            get
            {
                if (Utazosebesseg < 500) return "Alacsony sebességű";
                else if (Utazosebesseg < 1000) return "Szubszonikus";
                else if (Utazosebesseg < 1200) return "Transzszonikus";
                else return "Szuperszonikus";
            }
        }
        public Sebessegkategoria(int utazosebesseg)
        {
            Utazosebesseg = utazosebesseg;
        }
    }
    class Program
    {
        static List<Sebessegkategoria> sebeesseg = new List<Sebessegkategoria>();
        static int utasszallitok;
        static void Main(string[] args)
        {
            foreach (var item in File.ReadAllLines("utasszallitok.txt"))
            {
                sebeesseg.Add(new Sebessegkategoria(item));
            }
            Console.WriteLine("enter");
            Console.ReadLine();
        }
    }
}

