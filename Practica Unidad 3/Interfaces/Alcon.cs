﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Alcon : AnimalSalvaje, Flyable
    {
        public string volar()
        {
            return "vuela como un alcón ";
        }
    }
}
