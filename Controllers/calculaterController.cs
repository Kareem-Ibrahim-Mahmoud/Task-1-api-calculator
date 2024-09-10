using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test.point;

namespace test.Controllers
{

    
    [Route("api/[controller]")]
    [ApiController]
    public class calculaterController : ControllerBase
    {
        
        [HttpPost]
        public IActionResult AddNumber([FromBody] calc calc)
        {

            var result = new
            {

                Sum = calc.num1 + calc.num2,
                Sub = calc.num1 - calc.num2

            };
            if (ModelState.IsValid)
            {

            }
            else
            {
                return BadRequest("Plase Enter Your two Numbers...");
            }

            return Ok (result);
        }
    }
}
