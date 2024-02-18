using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca_klase_17_2_2024
{
    public class Student
    {
        public int MaticniBroj { get; }
        public string Ime { get; }
        public string Prezime { get; private set; }
        public string Adresa { get; set; }
        public double Visina { get; set; }
        public double Tezina { get; set; }
        public string BojaKose { get; set; }
        public int BrojCipela { get; set; }
        public List<string> PopisPredmeta { get; set; } = new List<string>();
        public List<int> PopisOcjena { get; set; } = new List<int>();

 
        public Student(int maticniBroj, string ime, string prezime)
        {
            this.MaticniBroj = maticniBroj;
            this.Ime = ime;
            this.Prezime = prezime;
        }


        public void DodajPredmetIOcjenu(string predmet, int ocjena)
        {
            PopisPredmeta.Add(predmet);
            PopisOcjena.Add(ocjena);
        }

 
        public void IspisiStudenta()
        {
            Console.WriteLine($"Matični broj: {MaticniBroj}\nIme: {Ime}\nPrezime: {Prezime}\nAdresa: {Adresa}\nVisina: {Visina}\n" +
                              $"Težina: {Tezina}\nBoja kose: {BojaKose}\nBroj cipela: {BrojCipela}\n");
            Console.WriteLine("Predmeti i ocjene:");
            for (int i = 0; i < PopisPredmeta.Count; i++)
            {
                Console.WriteLine($"{PopisPredmeta[i]}: {PopisOcjena[i]}");
            }
        }
    }
}
