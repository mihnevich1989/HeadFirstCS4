﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal interface IWorker
    {
        public string Job { get; }
        public void WorkTheNextShift();
    }
}
