using DAL.entities;
using DAL.interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace accountingbasic.Controllers
{
    [Route("api/incomeAndCost")]
    [ApiController]
    
    public class IncomeAndCostController : ControllerBase
    {
        private readonly IIncomeAndCostRepository _incomeAndCostRepository;
        public IncomeAndCostController(IIncomeAndCostRepository incomeAndCostRepository)
        {
            _incomeAndCostRepository = incomeAndCostRepository;
        }
        // GET: api/<IncomeAndCost>
        [HttpGet]

        public IEnumerable<IncomeAndCost> Get()
        {

            return _incomeAndCostRepository.GetIncomeAndCost().Result.ToList();
        }
        // GET api/<IncomeAndCost>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<IncomeAndCost>
        [HttpPost]
        public async Task<IActionResult> Post(IncomeAndCost incomeAndCost)
        {

            try
            {
                return Ok(_incomeAndCostRepository.CreateIncomeAndCost(incomeAndCost));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<IncomeAndCost>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IncomeAndCost>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
