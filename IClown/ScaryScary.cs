﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClown
{
    internal class ScaryScary : FunnyFunny, IScaryClown
    {
        private readonly int scaryThingCount;

        public string ScaryThingIHave { get { return $"{scaryThingCount} spiders."; } }

        public ScaryScary(string funnyThing, int scaryThingCount) : base(funnyThing)
        {
            this.scaryThingCount = scaryThingCount;
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine($"Boo! Gotcha! Look at my {ScaryThingIHave}");
        }
    }
}

