﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend1.Services
{
    public interface IRandomService
    {
        int Rand(int min, int max);
    }
}