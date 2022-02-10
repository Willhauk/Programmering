using System;
using System.Collections.Generic;
using System.Text;

namespace WpfDemoStackPanel
{
    class Questions
    {
        public Questions()
        {
            Quiz q = new Quiz();
            q.Add(new Questioncard("Vad är sveriges huvudstad?", "Stockholm"));
            q.Add(new Questioncard("Hur stor är solen?", "Stor"));
            q.Add(new Questioncard("Hur gammal är jag?", "3"));
            q.Add(new Questioncard("Vilken färg är grus?", "Grått"));
        }
    }
}
