using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Targ_masini
{

    public class Masina
    {
        public double model;
        public int firma;
        public string culoare;
        public int an;
        public double pret;
        public int [] datat=new int[3];
        public string [] optiuni=new string [11];
        

        public Masina()
        {
            pret = 0;
            an = 0;
            model = 0;
            firma = 0;
            culoare = string.Empty;
            datat[0]=0;
            datat[1] = 0;
            datat[2] = 0;
            optiuni[0] = string.Empty;
        }

        /*public Masina(string _model, string _firma, string _culoare, int _an, double _pret, List<int> _datat = input.Split(',').ToList(), List<string> _optiuni = input.Split(',').ToList())
        {

        }*/
        public void afisare()
        {

            Console.WriteLine("Masina model {0},culoare {1}, an {2} , pret {3}, datat {4} {5} {6}", model, firma, culoare, an, pret, datat[0],datat[1],datat[2]);
            Console.Write("Optiuni valabile: ");
            if (optiuni[0] == string.Empty)
            {
                Console.Write("NU exista optiuni pentru aceasta masina");
            }
            else
            {
                for (int j = 0; j < optiuni.Length; j++)
                {
                    Console.Write(optiuni[j] + ", ");
                }
            }
            Console.Write("\nFirma: " + firma);
        }

        public double getpret() { return pret; }
        public int getan() { return an; }
        public int getdataz() { return datat[0]; }
        public int getdatal() { return datat[1]; }
        public int getdataa() { return datat[2]; }
        public double getmodel() { return model; }
        public int getfirma() { return firma; }
        public  void setmodel()
        {
            Console.WriteLine("\nintroduceti numarul de model");
            model = Convert.ToDouble(Console.ReadLine());
        }
        public  int setfirma()
        {
            Console.WriteLine("\nintroduceti firma\n0-Necunoscuta\n1-Ciroen\n2-Suzuki\n3-Honda\n4-Fiat\n5-Volkswagen\n6-BMW\n7-Toyota\n8-Dacia\n9-Ford");
            firma = Convert.ToInt32(Console.ReadLine());
            if(firma>9||firma<0)
            {
                Console.WriteLine("Introduceti o valoare din cele prezentate");
                firma = Convert.ToInt32(Console.ReadLine());
            }
            return firma;
        }
        public  void setculoare()
        {
            Console.WriteLine("\nIntroduceti culoarea :");
            culoare = Console.ReadLine();
        }
        public  void setan()
        {
            Console.WriteLine("\nIntroduceti anul de fabricare:");
            an =Convert.ToInt32(Console.ReadLine());
        }
        public  void setpret()
        {
            Console.WriteLine("\nIntroduceti pretul $:");
            pret = Convert.ToDouble(Console.ReadLine());
        }
        public  void setdatat()
        {
            Console.WriteLine("\nintroduceti data tranzactiei (zz,ll,aaaa) :");
            string lista = Console.ReadLine();
            string[] data = lista.Split(',');
            datat[0] = Convert.ToInt32(data[0]);
            datat[1] = Convert.ToInt32(data[1]);
            datat[2] = Convert.ToInt32(data[2]);
        }
        public  void setop()
        {
            Console.WriteLine("\nintroduceti nr de optiuni valabile(max 10) si optiunile cu , :");
            int o = Convert.ToInt32(Console.ReadLine());
            for(int j=0;j<o;j++)
            {
                Console.Write("\nOptiunea nr." + j);
                optiuni[j] = Console.ReadLine();
            }
        }
        public string ConversieLaSir()
        {
            string[] numef = new string[10];
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
            string buff=" ";
            buff += numef[this.firma];
            buff += " ";
            buff += this.model;
            buff += " ";
            buff += this.culoare;
            buff += " din anul";
            buff += this.an;
            buff += " la un pret de";
            buff += this.pret;
            buff += "$ Tranzactie efectuata pe";
            buff += this.datat;
            buff += "\nOptiuni valabile :";
            if (optiuni[0] == string.Empty)
            {
                buff += "NU exista optiuni pentru aceasta masina";
            }
            else
            {
                for (int j = 0; j < optiuni.Length; j++)
                { 

                    buff += "-";
                    buff += optiuni[j];
                    buff += "\n";
                }
            }
            return buff;


        }
        
    }
}