using System;
using System.Collections.Generic;
using System.Text;

namespace MethodDemoMath
{
    class Demo
    {
        public void Run()
        {
            double minValue = 1000000;
            String input = "j";

            while (input.Equals("j"))
            {
                Console.WriteLine("Skriv in simtid i sekunder");
                string text = Console.ReadLine();
                double time = Convert.ToDouble(text);

                // Kanske nytt minsta värde. Spara i så fall.
                //minValue = Math.Min(minValue, time); 
                // Eller 
                minValue = Min(minValue, time);

                Console.WriteLine("Bästa tid är: " + minValue);

                Console.WriteLine("Vill du fortsätta j/n?");
                input = Console.ReadLine();


            }
            Console.WriteLine("Tack och hej!");
        }

        private double Min(double val1, double val2)
        {
            if (val1 < val2)
            {
                return val1;
            }
            else
            {
                return val2;
            }
        }
    }
}

// Utdrag från klasserna String, Math och Console följer nedan
/*
// https://docs.microsoft.com/en-us/dotnet/api/system.string?view=netcore-3.1
public sealed class String : ICloneable, IComparable, IComparable<string>, IConvertible, IEquatable<string>, System.Collections.Generic.IEnumerable<char>
{
    // kod utelämnad

    public bool Equals (string? value)
    {
        // kod utelämnad
        return ...
    }

    // kod utelämnad
}

// https://docs.microsoft.com/en-us/dotnet/api/system.math?view=netcore-3.1
public static class Math
{
    // kod utelämnad

    public static double Min (double val1, double val2)
    {
        // Möjligt innehåll (ej hänsyn tagen till NaN)
        if (val1 < val2)
        {
            return val1;
        }
        else 
        {
            return val2;
        }
    }

    // kod utelämnad

}

// https://docs.microsoft.com/en-us/dotnet/api/system.console?view=netcore-3.1
public static class Console
{
    // kod utelämnad

    public static string ReadLine ()
    {
        // kod utelämnad
        return ...
    }
    public static void WriteLine (string value)
    {
        // kod utelämnad
    }

    // kod utelämnad
}

 */
