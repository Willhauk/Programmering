using System;
using System.Collections.Generic;
using System.Text;

namespace Frågesport_GUI
{
    class Kort : ModerKort
    {

        private string svar;


        public Kort(String f, String s) : base(f)
        {

            svar = s;
        }



        public override void Skrivut()
        {
            Console.WriteLine(fråga);
        }

        public override String GetSvar()
        {


            return svar;

        }


    }
}
