using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationController : ControllerBase
    {
        private readonly ICalcService calcService;

        public CalculationController(ICalcService calcService)
        {
            this.calcService = calcService;
        }
        // GET: api/<CalculationController>
        [HttpGet]
        public ActionResult<List<Calculation>> Get()
        {
            return calcService.Get();
        }

        // GET api/<CalculationController>/5
        [HttpGet("{id}")]
        public ActionResult<Calculation> Get(string id)
        {
            var calculated = calcService.Get(id);

            if(calculated == null)
            {
                return NotFound($"Student with Id = {id} not found");
            }

            return calculated;
        }

        // POST api/<CalculationController>
        [HttpPost]
        public ActionResult<Calculation> Post([FromBody] Calculation calculation)
        {
            //calcService.Create(calculation);

            switch (calculation.Operation)
            {

                case "+":
                    calculation.Result = calculation.Number1 + calculation.Number2;
                    break;
                case "-":
                    calculation.Result = calculation.Number1 - calculation.Number2;
                    break;
                case "*":
                    calculation.Result = calculation.Number1 * calculation.Number2;
                    break;
                case "/":
                    calculation.Result = calculation.Number1 / calculation.Number2;
                    break;
                case "%":
                    calculation.Result = calculation.Number1 % calculation.Number2;
                    break;
            }

            calcService.Create(calculation);

            return CreatedAtAction(nameof(Get), new { id = calculation.Id }, calculation.Result);
        }
    }
}
