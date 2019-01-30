using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class SmartyPlayer : Player
    {
        private List<char> Letters;
        public SmartyPlayer()
        {
            this.Letters = new List<char>() { 'e',  'a', 'o', 'i', 'u', 't', 'n', 's', 'r', 'h', 'l', 'd', 'c', 'm', 'f', 'p', 'g', 'w', 'y', 'b', 'v', 'k', 'x', 'j', 'q', 'z' };
        }
        public override char Guess()
        {
            char nextLetter = Letters.First();
            Letters.Remove(nextLetter);
            return nextLetter;
        }
    }
}
