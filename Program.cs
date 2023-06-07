using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace projektZS
{

    class Program
    {
        static string[] beolvas = File.ReadAllLines("csokik.txt");
        static List<Napok> napok = new List<Napok>();
        static List<int> csokik = new List<int>();
        class Napok
        {
            public string nap, markak;
            public int csoki, arak;
            public Napok(string egysor)
            {
            string[] darabok = egysor.Split(';');
                nap = darabok[0];
                csoki = int.Parse(darabok[1]);
                markak = darabok[2];
                arak = int.Parse(darabok[3]);
            }

        }
        static void Main(string[] args)
        {
            for (int i = 1; i < beolvas.Length; i++)
            {
                napok.Add(new Napok(beolvas[i]));


            }

            feladat2();
            feladat3();
            feladat4();
            feladat5();
            feladat6();
            Console.WriteLine("Enter");
            Console.ReadLine();
        }
        static void feladat2()
        {
            int oszesen = 0;
            for (int i = 0; i < napok.Count; i++)
            {
                oszesen = oszesen + 1;
            }
            Console.WriteLine($"2 feladat:  {oszesen} napon at ettek csokit osszesen. ");
        }
        static void feladat3()
        {
            int n = napok.Count;
            int c = 0;

            for (int i = 0; i < n ; i++)
            {
                if (napok[i].csoki < 101)
                {
                    csokik.Add(napok[i].csoki);
                    c++;

                }

            }
            Console.WriteLine("Feladat 3: Ahany fajta csoki fogyott: {0}", c );
        }
        static void feladat4()
        {
            Console.WriteLine("Feladat 4:");
            int legtobb = napok[0].csoki;
            string tobb = napok[0].markak;
            for (int i = 1; i < napok.Count; i++)
            {
                if (napok[i].csoki > legtobb)
                {
                    legtobb = napok[i].csoki;
                    tobb = napok[i].markak;
                }
            }
            Console.WriteLine($"A legtobbet fogyasztott csoki : {tobb} {legtobb}db. ");
            int legkevesebb = napok[0].csoki;
            string keves = napok[0].markak;
            for (int i = 1; i < napok.Count; i++)
            {
                if (napok[i].csoki < legkevesebb)
                {
                    legkevesebb = napok[i].csoki;
                    keves = napok[i].markak;
                }
            }
            Console.WriteLine($"A legkevesebbett fogyasztott csoki : {keves} {legkevesebb}db.");
        }
        static void feladat5()
        {
            Console.WriteLine("Feladat 5:");
            //int ker = 100;
            int i = 0;
            //while (i < napok.Count && napok. = ker)
            {
                i++;
            }
            if (i < napok.Count)
            {
                Console.WriteLine($"Van benne snikers csoki." , i);
            }
            else
            {
                Console.WriteLine("Nincs benne snikers csoki.");
            }
        }
        static void feladat6()
        {
            Console.WriteLine("feladat 6: a csokik szama  novekvo sorrendben:");
            int n = csokik.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int maxindex = i;
                for (int j = 0; j < i; j++)
                {
                    if (csokik[j] > csokik[maxindex] +1)
                    {
                        maxindex = j;
                    }
                }
                 int tmp = csokik[i];
                 csokik[i] = csokik[maxindex];
                 csokik[maxindex] = tmp;
            }
            foreach (var sor in csokik)
            {
                Console.Write($",{sor}" );
            }
            Console.WriteLine();
        }
    }
}
