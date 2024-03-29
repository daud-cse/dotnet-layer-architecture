﻿using DAL.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IIncomeAndCostRepository
    {
        Task<IEnumerable<IncomeAndCost>> GetIncomeAndCost();
        Task<IncomeAndCost> CreateIncomeAndCost(IncomeAndCost IncomeAndCost);
       
    }
}
