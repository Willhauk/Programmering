using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Cat
    {
        private int age;
        public Cat(int a)
        {
            age = a;
        }


        public void Act()
        {
            for (int i = 0; i < age; ++i)
            {
                Console.Write("Mjau ");  
            }
            
        }
    }
}
