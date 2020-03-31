using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targ_masini
{
    class Program
    {
        public static string[] numef =new string[10];
        public static int[] firme = new int[10];
        /*for(int j=0;j<10;j++)
        {
            modele[j]=0;
        }*/
        public static int i = 0;
        static void Main(string[] args)
        {
            for (int j = 0; j < 10; j++)
            {
                firme[j] = 0;
            }
            Masina m1 = new Masina();
            m1.afisare();
            m1.setmodel();
            m1.ConversieLaSir();//CONVERSIE LA SIR
            setf();
            Menu();
            //int y=10;
            //string x = "pititci";
            //Console.WriteLine("Erau odata {0} {1}",y,x);
        }
        static void Menu()
        {
            Masina[] masini = new Masina[50];
            for(int j=0;j<50;j++)
            {
                masini[j] = new Masina();
            }
            int c;
            string menu = "\nC :Adauga automobile\nA :Afiseaza automobile disponibile\nT :Afiseaza modelul cel mai cautat\nG :Grafic preturi pe o anumita zi\nZ :Tranzactii intr-o anumita zi\nS :Conversie la sir\nI :Info\nX :Exit";
            Console.WriteLine(menu);
            do
            {

                string op = Console.ReadLine();
                switch (op)
                {
                    case "c":
                        {
                            
                            Console.WriteLine("Introduceti numarul de masini pe care doriti sa le adaugati");
                            c = Convert.ToInt32(Console.ReadLine());
                            for(int j=0;j<c;j++)
                            {
                                try
                                {
                                    masini[j].setmodel();
                                    int v = masini[j].setfirma();
                                    firme[v]= firme[v]+1;
                                    Console.WriteLine();
                                    Console.Write("Indicii curenti ai firmelor :");
                                    for (int k=0;k<10;k++)
                                    {
                                        Console.Write(firme[k]);
                                    }
                                    masini[j].setculoare();
                                    masini[j].setan();
                                    masini[j].setpret();
                                    masini[j].setdatat();
                                    masini[j].setop();
                                    i++;
                                }
                                catch
                                {
                                    Console.WriteLine("A aparut o eroare");
                                }
                            }
                            Console.ReadKey();
                            Console.WriteLine(i + " masini adaugate");
                            break;
                        }
                    case "a":
                        {
                            try
                            {
                                for (int j = 0; j < i; j++)
                                {
                                    masini[j].afisare();
                                    Console.Write(numef[masini[j].getfirma()]);
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Nici o masina inregistrata cu parametrii");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case "t":
                        {
                            Console.WriteLine("\nModelul ce mai cautat este :" + numef[Max()]);
                            Console.ReadKey();
                            break;
                        }
                    case "s":
                        { 
                            Console.ReadKey();
                            break;
                        }
                    case "g":
                        { 
                            //Nu este completat momentan
                            Console.ReadKey();
                            break;
                        }
                    case "z":
                        {
                            int z, l, a,ok=0;
                            Console.WriteLine("Introduceti ziua");
                            z = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Introduceti luna");
                            l = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Introduceti anul");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("S-au gasit :");
                            for (int j=0;j<i;j++)
                            {
                                if (z == masini[j].getdataz() && l == masini[j].getdatal() && a == masini[j].getdataa());
                                {
                                    ok = 1;
                                    masini[j].afisare();
                                    Console.Write(numef[masini[j].getfirma()]);
                                }
                            }
                            if(ok==0)
                            {
                                Console.Write("0 masini cu aceasta data de tranzactie");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case "i":
                        {
                            Console.WriteLine("Proiect realizat de Ionut Taran");
                            Console.ReadKey();
                            break;
                        }
                    case "x":
                        return;
                }
                Console.WriteLine("\nAlege o optiune");
            } while (true);
        }
        static void setf()
        {
            numef[0] = "Necunoscuta";
            numef[1] = "Citroen";
            numef[2] = "Suzuki";
            numef[3] = "Honda";
            numef[4] = "Fiat";
            numef[5] = "Volkswagen";
            numef[6] = "BMW";
            numef[7] = "Toyota";
            numef[8] = "Dacia";
            numef[9] = "Ford";
        }
        static int Max()
        {
            int max = 0;
            for (int j = 0; j < 10; j++)
            {
                if (max < firme[j])
                {
                    max = j;
                }
            }
            return max;
        }
    }
}
