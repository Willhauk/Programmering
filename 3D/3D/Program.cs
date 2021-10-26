using System;

namespace _3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Databas db = new Databas();
            db.Add(new CD("Janne", "De 8 Dvärgarna"));
            db.Add(new CD("Bibbi", "Snövit"));

            db.Add(new DVD("Pingu The Movie", "Ove Bröd"));
            db.Add(new DVD("Indianen Jonas: Raiders Of The Lost Bark", "JK Bowling"));

            db.Skrivut();
        }
    }
}
