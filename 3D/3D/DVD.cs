using System;
using System.Collections.Generic;
using System.Text;

namespace _3D
{
    class DVD: Sak
    {
        private string regissör;

        public DVD(string titel, string regissör)
        {
            this.titel = titel;
            this.regissör = regissör;
        }

        public override void Skrivut()
        {
            Console.WriteLine("DVD, namn: " + titel);
            Console.WriteLine("Regissör: " + regissör);
        }
    }
}
