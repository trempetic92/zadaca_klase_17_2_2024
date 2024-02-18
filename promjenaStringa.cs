using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca_klase_17_2_2024
{
    public class promjenaStringa
    {

        //Tu je napravljen overload za izmjenu stringa
        public static string izmjeniString(string s, int a)
        {
            string prazniProstori = new string(' ', a);
            var slova = s.ToCharArray();
            string rezultat = String.Join(prazniProstori, slova);
            return rezultat;
        }
        public static string izmjeniString(string s)
        {
            char[] znakovi = s.ToCharArray();
            for (int i = 0; i < znakovi.Length; i++)
            {
                if (char.IsLower(znakovi[i]))
                {
                    znakovi[i] = char.ToUpper(znakovi[i]);
                }
                else
                {
                    znakovi[i] = char.ToLower(znakovi[i]);
                }
            }
            return new string(znakovi);
        }

        //mogao je i ovo biti overload da sam poslao char[]
        public  static string sifriranjeStringa(string s)
        {
            string abeceda = "ABCČĆDĐEFGHIJKLMNOPRSŠTUVZŽ";
            string rezultat = "";

            foreach (char c in s)
            {
                int index = abeceda.IndexOf(char.ToUpper(c));
                if (index != -1)
                {
                    char novoSlovo = abeceda[(index + 2) % abeceda.Length];
                    rezultat += char.IsLower(c) ? char.ToLower(novoSlovo) : novoSlovo;
                }
                else
                {
                    rezultat += c;
                }
            }
            return rezultat;
        }

        public static string zagradeString(string s)
        {
            return "<" + s + ">";
        }

    }
}
