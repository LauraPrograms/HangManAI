using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    abstract class Player
    {
        public abstract char Guess();//this means all the children will have their own version of it
    }
}
