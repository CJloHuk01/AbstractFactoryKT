using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Ork :IMob
    {
        public void Attack() => Console.WriteLine("Orc attacks!");
    }
}
