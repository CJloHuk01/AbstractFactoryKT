﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Dragon : IMob
    {
        public void Attack() => Console.WriteLine("дракон атакует огнем");
    }
}
