using System;
using System.Collections.Generic;
using System.Text;

namespace WpfDemoStackPanel
{
    class Quiz
    {
        private List<Questioncard> frågor;
        public int tal = 0;

        public Quiz()
        {
            frågor = new List<Questioncard>();
        }



        public void Add(Questioncard ensak)
        {
            frågor.Add(ensak);
        }

        public void Skrivut()
        {
            foreach (Questioncard fr in frågor)
            {


                if (fr.Skrivut() == true)
                {
                    tal += 1;
                }

                Console.WriteLine("Du har " + tal + " av " + frågor.Count + " rätt!");

            }
        }
    }
}
