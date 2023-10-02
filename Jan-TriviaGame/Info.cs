using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Jan_TriviaGame
{
    internal class Info
    {
        public void DisplayInfo()
        {
            const string barrior = "***********************************************";
            WriteLine(barrior);
            WriteLine();
            WriteLine("Name:\t\tFatima Jan");
            WriteLine("Course:\t\tITDEV-115-200");
            WriteLine("Intructor:\tJanese Christie");
            WriteLine("Assignment:\tTRIVIA GAME");
            WriteLine("Date:\t\t" + DateTime.Today.ToShortDateString());
            WriteLine();
            WriteLine(barrior);
        }
    }
}
