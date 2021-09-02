using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Solution
    {
        // konstruktor
        public Solution()
        {
        }
        public void Uppgift_1A()
        {
            Console.WriteLine("Vad heter du?");
            string namn = Console.ReadLine();
            Console.WriteLine("Hej " + namn + ". Varmt Välkommen");
            Console.WriteLine();

        }

        public void Uppgift_1B()
        {
            Console.WriteLine("Mata in bredd:");
            string bredd = Console.ReadLine();
            Console.WriteLine("Mata in höjd:");
            string höjd = Console.ReadLine();
            double bredd1 = Convert.ToDouble(bredd);
            double höjd1 = Convert.ToDouble(höjd);
            double area = bredd1 * höjd1 / 2;
            Console.WriteLine("Arean = ");
            Console.WriteLine(area);



        }

        public void Uppgift_2A()
        {
            Console.WriteLine("Gissa mitt favorittal");
            int tal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gissa mitt favorittal");
            if (tal == 3)
            {
                Console.WriteLine("Grattis du kissade rätt");
            }
            else
            {
                Console.WriteLine("Du hade fel");
            }
            




        }

       // public void Uppgift_2B()
        //{
          //  Random tärning1 = new Random();
         //   int antalTärningsögon = tärning1.Next(1, 21);
           // Console.WriteLine("Tärningen visar: " + antalTärningsögon);
            //int antalTärningsogon2 = tärning1.Next(1, 21);
            //Console.WriteLine("Tärningen visar: " + antalTärningsogon2);
            //if (antalTärningsögon == antalTärningsogon2)
            //{
              //  Console.WriteLine("Vinst");
                
           // }

            //else 
            //{
              //  Console.WriteLine("Förlust");
            //}
                


       // }

        public void Uppgift_3A()
        {
            
                
                for (int räknare = 1; räknare < 6; räknare = räknare + 1)
                {
                    Console.Write( räknare + ",");
                
                }
            Console.WriteLine();
        }

        public void Uppgift_3B()
        {


            for (int räknare1 = 5; räknare1 < 21; räknare1 = räknare1 + 3)
            {
                Console.Write(räknare1 + ",");

            }
            Console.WriteLine();
        }

        public void Uppgift_4A()
        {
            int räknare = 1;
            while (räknare < 6) 
            {
                Console.Write(räknare + ",");
                räknare = räknare + 1;
            }

            Console.WriteLine();

        }

        public void Uppgift_5A()
        {
            String input = "j";
            while (input.Equals("j"))

            {
                Console.WriteLine("Gissa mitt favvotal!");
               
                int tal = Convert.ToInt32(Console.ReadLine());

                
                if (tal == 15)
                {
                    Console.WriteLine("Grattis du kissade rätt");
                }
                else
                {
                    Console.WriteLine("Du hade fel");
                    Console.WriteLine("Vill du gissa igen? j/n");
                }
                
                input = Console.ReadLine();
            }
            Console.WriteLine("Tackk!");
            Console.WriteLine();
        }

        public void Uppgift_6()
        { 
             Random tärning1 = new Random();
        int antalTärningsögon = tärning1.Next(1, 7);
        Console.WriteLine("Tärningen visar: " + antalTärningsögon);
            int antalTärningsogon2 = tärning1.Next(1, 7);
        Console.WriteLine("Tärningen visar: " + antalTärningsogon2);
           
            if (antalTärningsögon + antalTärningsogon2 == 12)
            {
                Console.WriteLine("Storvinst!");
            }


            else if (antalTärningsögon == antalTärningsogon2)
            {
                Console.WriteLine("Vinst");
                
            }

            else 
            {
                Console.WriteLine("Förlust");
            }
        }


        public void Uppgift_7()
        {
            string[] lista = { "3", "5", "7", "9", "11", "13" };
            Console.WriteLine(lista[0]);
            Console.WriteLine(lista[1]);
            Console.WriteLine(lista[2]);
            Console.WriteLine(lista[3]);
            Console.WriteLine(lista[4]);
            Console.WriteLine(lista[5]);
            Console.WriteLine();

             int[] tal = new int[6];
            tal[0] = 3;
            tal[1] = 5;
            tal[2] = 7;
            tal[3] = 9;
            tal[4] = 11;
            tal[5] = 13;


            foreach(int talet in tal)
            {
                Console.WriteLine(talet + ", ");
            }
        
        }

        public void Test()
        {
            int[] svar = new int[6];
            svar[0] = 4;
            for(int i = 1; i < 6; i = i+1)
            {
                svar[i] = svar[i - 1] + 2;
            }
            foreach (int t in svar)
            {
                Console.Write(t + ", ");
            }

        }

        public void Uppgift_8B()
        {
            int[] tal = new int[6];
            tal[0] = 3;
            tal[1] = 5;
            tal[2] = 7;
            tal[3] = 9;
            tal[4] = 11;
            tal[5] = 13;

            foreach (int i in tal)
            {
                Console.Write("{0}, ", i + 1);
            }

        }

        public void Uppgift_9A()
        {
            printAgent();

        }

        private void printAgent()
        {
            Console.WriteLine("Välkommen Agent X. Du luktar gott idag!");
        }

        public void Uppgift_9B()
        {
            
            Console.WriteLine("Skriv in ett tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv ett till tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(tal1 + tal2);
        }

        public void Uppgift_9B2()
        {
            Console.WriteLine("Skriv in ett tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv ett till tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ett till");
            int tal3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Addera(tal1 , tal2 , tal3));
            
        }

        private int Addera(int x, int y, int a)
        {
            return x + y + a;
        }

        public void Uppgift_10()
        {
            
            String[] lista = new String[100];
            String input = "j";
            int räknare = 0;
            while (input.Equals("j"))
            {
                Console.WriteLine("Vad vill du lägga till för vara?");
                lista[räknare] = Console.ReadLine();
                räknare = räknare + 1;
                Console.WriteLine("Vill du lägga till något mer? j/n");
                input = Console.ReadLine();
            }
            foreach (string i in lista)
            {
                if (i != null)
                {
                    Console.Write(i + ", ");
                }
                
            }
            

           




        }

    }
}
