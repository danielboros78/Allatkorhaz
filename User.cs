using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allatkorhaz
{
    public class User
    {
        int id;
        string nev;
        string jelszo;
        string teljesNev;
        int jog;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Jelszo { get => jelszo; set => jelszo = value; }
        public string TeljesNev { get => teljesNev; set => teljesNev = value; }
        public int Jog { get => jog; set => jog = value; }

        public User(int id, string nev, string jelszo, string teljesNev, int jog)
        {
            Id = id;
            Nev = nev;
            Jelszo = jelszo;
            TeljesNev = teljesNev;
            Jog = jog;
        }
    }
}
