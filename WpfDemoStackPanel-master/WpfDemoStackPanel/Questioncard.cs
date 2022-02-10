using System;
using System.Collections.Generic;
using System.Text;

namespace WpfDemoStackPanel
{
    class Questioncard
    {
        private string fråga;
        private string svar;

        public Questioncard(string fråga, string svar)
        {
            this.fråga = fråga;
            this.svar = svar;
        }

        public bool Skrivut()
        {
            Console.WriteLine("Fråga: " + fråga);

            if (svar == Console.ReadLine())
            {
                Console.WriteLine("Du gissade rätt! ");
                return true;

            }
            else
            {
                Console.WriteLine("Du gissade fel!");

                return false;
            }
        }

    }
}
