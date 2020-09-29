using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosProjekt
{
    class Harcos
    {
        string nev;
        int szint;
        int tapasztalat;
        int eletero;
        int alapEletero;
        int alapSebzes;

        public Harcos(string nev, int statuszSablon)
        {
            this.nev = nev;
            szint = 1;
            tapasztalat = 0;
            switch (statuszSablon)
            {
                case 1: this.alapEletero = 15; this.alapSebzes = 3; break;
                case 2: this.alapEletero = 12; this.alapSebzes = 4; break;
                case 3: this.alapEletero = 8; this.alapSebzes = 5; break;
                default: this.alapEletero = 15; this.alapSebzes = 3; break;
            }
        }

        public string Nev { get => nev; set => nev = value; }
        public int Szint { get => szint; set => szint = value; }
        public int Tapasztalat { get => tapasztalat; set => tapasztalat = value; }
        public int Eletero { get => eletero; set => eletero = value; }
        public int AlapEletero { get => alapEletero; }
        public int AlapSebzes { get => alapSebzes; }
        public int Sebzes { get => alapSebzes+szint; }


    }
}
