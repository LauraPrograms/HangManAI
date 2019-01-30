using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new ABCplayer();
            Player p2 = new HumanPlayer();
            Player p3 = new RandomPlayer();
            Player p4 = new BruteForcePlayer();
            Player p5 = new SmartyPlayer();
            HangmanGame hg = new HangmanGame(p5);
        }
    }
}
