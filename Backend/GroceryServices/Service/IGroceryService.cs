﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryServices.Types;

namespace GroceryServices.Service
{
    public interface IGroceryService
    {
        Task<List<Grocery>> GetAllPendingGroceryList();
    }
}