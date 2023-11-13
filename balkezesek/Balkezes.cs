using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balkezesek
{
    public class Balkezes
    {
        string nev;
        string elso;
        string utolso;
        int suly;
        int magassag;

        public Balkezes(string nev, string elso, string utolso, int suly, int magassag)
        {
            this.nev = nev;
            this.elso = elso;
            this.utolso = utolso;
            this.suly = suly;
            this.magassag = magassag;
        }

        public string Nev { get => nev; }

        public int ElsoEv { get => int.Parse(elso.Substring(0,4)); }
        public int ElsoHonap { get => int.Parse(elso.Substring(5,2)); }
        public int ElsoNap { get => int.Parse(elso.Substring(8,2)); }

        public int UtolsoEv { get => int.Parse(utolso.Substring(0, 4)); }
        public int UtolsoHonap { get => int.Parse(utolso.Substring(5, 2)); }
        public int UtolsoNap { get => int.Parse(utolso.Substring(8, 2)); }

        public int Suly { get => suly; }
        public int Magassag { get => magassag; }
    }
}
