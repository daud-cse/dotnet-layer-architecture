using DAL.Contexts;
using DAL.entities;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class IncomeAndCostRepository: IIncomeAndCostRepository
    {

        private readonly DotNetDbContext _dotNetDbContext;
  
        public IncomeAndCostRepository(DotNetDbContext dotNetDbContext)
        {
            _dotNetDbContext = dotNetDbContext;
            
        }
        public async Task<IEnumerable<IncomeAndCost>> GetIncomeAndCost()
        {
            try
            {
                var lstUser = new List<IncomeAndCost>();

                lstUser = _dotNetDbContext.IncomeAndCost.ToList();
                
                return await System.Threading.Tasks.Task.FromResult(lstUser);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public async Task<IncomeAndCost> CreateIncomeAndCost(IncomeAndCost incomeAndCost)
        {
            try
            {
             
                _dotNetDbContext.IncomeAndCost.Add(incomeAndCost);
                _dotNetDbContext.SaveChanges();
                return await System.Threading.Tasks.Task.FromResult(incomeAndCost);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
