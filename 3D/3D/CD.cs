using System;
using System.Collections.Generic;
using System.Text;

namespace _3D
{
    class CD: Sak
    {
        private string artist;
        private string v;

        public CD(string v)
        {
            this.v = v;
        }

        public CD(string titel, string artist)
        {
            this.titel = titel;
            this.artist = artist;
        }

        public override void Skrivut()
        {
            Console.WriteLine("CD, namn: " + titel);
            Console.WriteLine("Artist: " + artist);
        }
    }
}
