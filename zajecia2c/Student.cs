using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia2c
{
    class Student : Osoba
    {
        private int rok;
        private int grupa;
        private int nrIndeksu;

        

        public Student(string imie_, string nazwisko_, string dataurodzenia_, int rok_, int grupa_, int nrIndeksu_) : base(imie_, nazwisko_, dataurodzenia_)

        {
            this.rok = rok_;
            this.grupa = grupa_;
            this.nrIndeksu = nrIndeksu_;
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine($"Rok studiów: {this.rok}, grupa: {this.grupa}, numer indeksu: {this.nrIndeksu}");

            Console.WriteLine("Oceny studenta: ");
            // TODO
          
        }

     
    }
}
