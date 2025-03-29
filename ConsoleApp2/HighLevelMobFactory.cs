using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class HighLevelMobFactory :IMobFactory
    {
        
        private static readonly Random _random = new Random();
        public IMob CreateMob()
        {
            return _random.Next(0, 2) == 0 ? new Dragon() : new Cyclop();
        }

    }
}
