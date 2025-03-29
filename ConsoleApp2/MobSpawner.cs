using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MobSpawner
    {
        private IMobFactory _mobFactory;

        public MobSpawner(IMobFactory mobFactory)
        {
            _mobFactory = mobFactory;
        }

        public void SpawnMob()
        {
            IMob mob = _mobFactory.CreateMob();
            mob.Attack();
        }
    }
}
