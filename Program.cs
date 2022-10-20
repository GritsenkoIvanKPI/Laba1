using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ало");
            Player Nagibator228 = new Player("Nagibator228", 1);
            Player Tolik3000 = new Player("Tolik3000", 1);
            Nagibator228.WinGame("Tolik3000", 25, DateTime.Now);
            Tolik3000.LoseGame("Nagibator228", 25, DateTime.Now);
            Nagibator228.WinGame("Tolik3000", 35, DateTime.Now);
            Tolik3000.LoseGame("Nagibator228", 35, DateTime.Now);
            Console.WriteLine(Nagibator228.GetStats());
            Console.WriteLine(Tolik3000.GetStats());
        }
    }
}
