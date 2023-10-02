using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan_TriviaGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Info i = new Info();
            i.DisplayInfo();
            Controller controller = new Controller();
            controller.Play();
        }
    }
}
