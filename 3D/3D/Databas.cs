using System;
using System.Collections.Generic;
using System.Text;

namespace _3D
{
    class Databas
    {
        public List<Sak> saker;

        public Databas()
        {
            saker = new List<Sak>();
        }

        public void Add(Sak ensak)
        {
            saker.Add(ensak);
        }

        public void Skrivut()
        {
            foreach (Sak sak in saker)
            {
                sak.Skrivut();
            }
        }


    }
}
