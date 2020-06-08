using System;
using The_War.Models;

namespace The_War
{
    class Progra
    {
        static void Main(string[] args)
        {
            Wizard A = new Wizard("Wizard");
            Ninja B = new Ninja("Ninja");
            Samurai C = new Samurai("Samurai");
            A.Attack(B);
            A.Heal(B);
            B.Attack(C);
            C.Meditate();
        }
    }
}
