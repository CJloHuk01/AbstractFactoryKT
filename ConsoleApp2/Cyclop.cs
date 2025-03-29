using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Cyclop : IMob
    {
        public void Attack() => Console.WriteLine("Циклоп атакует дубинкой");
    }
}
