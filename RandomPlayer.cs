using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class RandomPlayer : Player

    {
        private List<char> Letters;
        public RandomPlayer()
        {
            this.Letters = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' }; ;
        }
        public override char Guess()
        {
            
            Random number = new Random();
            int index = number.Next(0, Letters.Count()-1);
            char randomLetter = Letters[index];
            Letters.Remove(randomLetter);
            return randomLetter;
        }
        
    }
}