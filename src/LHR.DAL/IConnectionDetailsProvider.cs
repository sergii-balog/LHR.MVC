﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LHR.DAL
{
    public interface IConnectionDetailsProvider
    {
        string GetConnectionString();
    }
}
