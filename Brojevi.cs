using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca_klase_17_2_2024
{
    public static class Brojevi
    {

        //Neznam kako bi nazvao overload metodu, svaka ima posebno ime :/
        //Viđe bi mi bilo smisleno ako bi bila neka manipulacija
        public static bool jeProst(int a)
        {
            if (a <= 1) return false;
            if (a == 2) return true;
            if (a % 2 == 0) return false;

            var gornjaGranica = (int)Math.Floor(Math.Sqrt(a));

            for (int i = 3; i <= gornjaGranica; i += 2)
            {
            if (a % i == 0)
                return false;
            }

             return true;  
        }
        public static bool jeSavrsen(int a)
        {
            int suma = 0;
            while (true)
            {
                   
                for (int i = 1; i <= a / 2; i++)
                {
                    if (a % i == 0)
                    {
                        suma += i;
                    }
                }
                if (suma == a && a != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool jeArmstrongov(int a)
        {
            int originalniBroj = a;
            int suma = 0;
            int brojZnamenaka = a.ToString().Length;

            while (a > 0)
            {
                int znamenka = a % 10;
                suma += (int)Math.Pow(znamenka, brojZnamenaka);
                a /= 10;
            }

            return suma == originalniBroj;
        }
        public static double IzracunPi(int brojIteracija)
        {
            double pi = 0;

            for (int i = 0; i < brojIteracija; i++)
            {
                double clan = 1.0 / (i * 2 + 1);
                if (i % 2 == 0)
                {
                    pi += clan;
                }
                else
                {
                    pi -= clan;
                }
            }

            pi *= 4;
            return pi;
        }
    }
}
