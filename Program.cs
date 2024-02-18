using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca_klase_17_2_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool nastavi = true;
            while (nastavi)
            {
                Console.WriteLine("\nOdabir zadatka:\n");
                Console.WriteLine("1. Provjera prostog broja");
                Console.WriteLine("2. Provjera savršenog broja");
                Console.WriteLine("3. Provjera armstrongovog broja");
                Console.WriteLine("4. Izračun PI broja");
                Console.WriteLine("5. Manipulacija stringa razmakom");
                Console.WriteLine("6. Manipulacija stringa promjenom veliko-malo");
                Console.WriteLine("7. Manipulacija stringa šifriranje");
                Console.WriteLine("8. Manipulacija stringa zagrade");
                Console.WriteLine("9. Unos studenata");
                Console.WriteLine("0. Izlaz\n\n");

                string odabir = Console.ReadLine();
                Console.WriteLine();

                switch (odabir)
                {
                    case "1":
                        Console.Write("Unesite broj za provjeru jeli prost: ");
                        int a = Int32.Parse(Console.ReadLine());
                        if (Brojevi.jeProst(a))
                        {
                            Console.WriteLine($"Unešeni broj {a} je prost broj.");
                        }
                        else
                        {
                            Console.WriteLine($"Unešeni broj {a} nije prost broj.");
                        }
                        break;
                    case "2":
                        Console.Write("Unesite broj za provjeru jeli savršen: ");
                        a = Int32.Parse(Console.ReadLine());
                        if (Brojevi.jeSavrsen(a))
                        {
                            Console.WriteLine($"Unešeni broj {a} je savršen broj.");
                        }
                        else
                        {
                            Console.WriteLine($"Unešeni broj {a} nije savršen broj.");
                        }
                        break;
                    case "3":
                        Console.Write("Unesite broj za provjeru jeli armstrongov broj: ");
                        a = Int32.Parse(Console.ReadLine());
                        if (Brojevi.jeArmstrongov(a))
                        {
                            Console.WriteLine($"Unešeni broj {a} je armstrongov broj.");
                        }
                        else
                        {
                            Console.WriteLine($"Unešeni broj {a} nije armstrongov broj.");
                        }
                        break;
                    case "4":
                        Console.Write("Unesite broj iteracija za izračun PI znamenki: ");
                        a = Int32.Parse(Console.ReadLine());
                        Console.WriteLine($"Pi znamenke su: {Brojevi.IzracunPi(a)}");
                        break;
                    case "5":
                        Console.Write("Unesite riječ ili rečenicu: ");
                        string recenica = Console.ReadLine();
                        Console.Write("Unesite broj razmaka: ");
                        a = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Riječ ili rečenica sa brojem razmaka između slova:\n");
                        Console.WriteLine(promjenaStringa.izmjeniString(recenica,a));
                        break;
                    case "6":
                        Console.Write("Unesite riječ ili rečenicu: ");
                        recenica = Console.ReadLine();
                        Console.WriteLine("Zamjenjena mjesta velikih i malih slova:\n");
                        Console.WriteLine(promjenaStringa.izmjeniString(recenica));
                        break;
                    case "7":
                        Console.Write("Unesite riječ ili rečenicu: ");
                        recenica = Console.ReadLine();
                        Console.WriteLine("Šifrirana rečenica je: \n");
                        Console.WriteLine(promjenaStringa.sifriranjeStringa(recenica));                       
                        break;
                    case "8":
                        Console.Write("Unesite riječ ili rečenicu: ");
                        recenica = Console.ReadLine();
                        Console.WriteLine("Rečenica sa zagradama: \n");
                        Console.WriteLine(promjenaStringa.zagradeString(recenica));
                        break;
                    case "9":
                        Console.WriteLine("--Unos studenata--");

                        bool ocemojos = true;
                        List<Student> studenti = new List<Student>();
                        while (ocemojos)
                        {
                            Console.Write("Matični broj: ");
                            int maticniBroj = int.Parse(Console.ReadLine());

                            Console.Write("Ime: ");
                            string ime = Console.ReadLine();      
                            
                            Console.Write("Prezime: ");
                            string prezime = Console.ReadLine();
                            Student noviStudent = new Student(maticniBroj, ime,prezime);

                            Console.Write("Adresa: ");
                            noviStudent.Adresa = Console.ReadLine();

                            Console.Write("Visina: ");
                            noviStudent.Visina = double.Parse(Console.ReadLine());

                            Console.Write("Težina: ");
                            noviStudent.Tezina = double.Parse(Console.ReadLine());

                            Console.Write("Boja kose: ");
                            noviStudent.BojaKose = Console.ReadLine();

                            Console.Write("Broj cipela: ");
                            noviStudent.BrojCipela = Int32.Parse(Console.ReadLine());

                            Console.Write("Broj predmeta? ");
                            int brojPredmeta = Int32.Parse(Console.ReadLine());

                            List<string> predmeti = new List<string>();
                            List<int> ocjene = new List<int>();

                            for (int i = 0; i < brojPredmeta; i++)
                            {
                                Console.Write($"Naziv {i + 1}. predmeta: ");
                                string predmet = Console.ReadLine();
                                predmeti.Add( predmet );

                                Console.Write($"Ocjena predmeta {predmet} : ");
                                int ocjena = Int32.Parse(Console.ReadLine());
                                ocjene.Add( ocjena );
                            }
                            noviStudent.PopisPredmeta = predmeti;
                            noviStudent.PopisOcjena = ocjene;
                            studenti.Add(noviStudent);

                            Console.Write("Želite li dodati još studenata? (da/ne): ");
                            string odgovor = Console.ReadLine().ToLower();
                            if(odgovor == "ne")
                            {
                                Console.WriteLine();
                                noviStudent.IspisiStudenta();
                                break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("\nUnesite valjani broj zadatka.");
                        Console.Write(odabir);
                        break;
                }
            }
            Console.ReadKey();

        }
    }
}
