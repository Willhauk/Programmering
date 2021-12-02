using System;
using System.Collections.Generic;
using System.Text;

namespace Frågesport_GUI
{
    class Kortlek
    {
        private List<ModerKort> frågor;

        public Kortlek()
        {
            frågor = new List<ModerKort>();
            //frågor.Add(new Kort("Vad är 5+5?", "10"));
            //frågor.Add(new Kort("Vad heter Sveriges huvudstad?", "Stockholm"));
            //frågor.Add(new Kort("Hur många dagar är det på ett år?", "365"));
            //frågor.Add(new Kort("Hur många kort är det i en kortlek?", "52"));
            List<String> flersvar = new List<String>();
            flersvar.Add("2");
            flersvar.Add("3");
            flersvar.Add("4");
            flersvar.Add("8");

            List<String> flersvar2 = new List<String>();
            flersvar2.Add("New York");
            flersvar2.Add("Washington DC");
            flersvar2.Add("Texas");
            flersvar2.Add("LA");

            List<String> flersvar3 = new List<String>();
            flersvar3.Add("10");
            flersvar3.Add("46");
            flersvar3.Add("3");
            flersvar3.Add("67");

            List<String> flersvar4 = new List<String>();
            //flersvar4.Add("Gröt");
            flersvar4.Add("Äta grus");
            flersvar4.Add("Lida");
            flersvar4.Add("Andas");
            flersvar4.Add("42");


            frågor.Add(new Flersvar("Hur många ben har en kossa?", flersvar, "4"));
            frågor.Add(new Flersvar("Vad heter USA's huvudstad?", flersvar2, "Washington DC"));
            frågor.Add(new Flersvar("Hur många gruskorn finns det på jorden?", flersvar3, "46"));
            frågor.Add(new Flersvar("Vad är meningen med livet?", flersvar4, "42"));

        }

        public ModerKort Drakort()
        {
            if (frågor.Count == 0)
            {
                return null;
            }
            else
            {
                int lastIndex = frågor.Count - 1;
                ModerKort kort = frågor[lastIndex];
                frågor.RemoveAt(lastIndex);
                return kort;
            }
        }

        public bool HasCards()
        {
            return frågor.Count > 0;
        }


    }
}
