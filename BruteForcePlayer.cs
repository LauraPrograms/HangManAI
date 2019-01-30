using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class BruteForcePlayer : Player
    {
        private List<char> Letters;
        public BruteForcePlayer ()
        {
            this.Letters = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' }; ;
        }
        public override char Guess()
        {
            char nextLetter = Letters.First();
            Letters.Remove(nextLetter);
            return nextLetter;                       
        }
    }
}
