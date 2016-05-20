using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3.Indexers
{
    public class Sentence
    {
        string[] words = "The quick brown fox".Split();



        public string this[int wordNum]
        {
            get { return words[wordNum]; }
            set { words[wordNum] = value; }
        }

        //public string this[string wordNum]=> words. [wordNum];

    }
}
