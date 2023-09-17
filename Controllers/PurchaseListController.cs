using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace PurchaseList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        public Purchases.IAdd add;

        public Controller(Purchases.IAdd iadd)
        {
            add = iadd;            
        }

        [HttpPost]
        public IActionResult AddPurchase([FromBody] string item)
        {
            add.Add(item);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = Purchases.GetAllPurchases();
            return new JsonResult(result);
        }
    }
}