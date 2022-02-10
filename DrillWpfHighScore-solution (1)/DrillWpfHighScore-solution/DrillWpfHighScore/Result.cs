using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DrillWpfHighScore
{
    class Result : IComparable<Result>
    {
        private int score;
        // lägg till name

        // lägg till konstruktor

        // property
        public int Score
        {
            get
            {
                return score;
            }
        }

        // lägg till ToString() eller property Name
        public int CompareTo([AllowNull] Result other)
        {
            if (other == null)
            {
                // this is first
                return 1;
            }
            else if (Score > other.Score)
            {
                // this is first
                return 1;
            }
            else
            {
                // other is first
                return -1;
            }                
        }
    }
}
