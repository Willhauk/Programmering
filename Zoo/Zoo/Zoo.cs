using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Zoo
    {
        private List<Cat> cats;
        private List<Dog> dogs;
    }

    public Zoo()
    {
        cats = new List<Cat>();

        cats.Add(new Cat(4));
        cats.Add(new Cat(4));
        cats.Add(new Cat(4));

        dogs = new List<Dog>();
        dogs.Add(new Dog(3));
        dogs.Add(new Dog(3));
    }

    public Void Run()
    {
        foreach (Cat katt in cats)
        {
            katt.Act();
        }
    }

}
