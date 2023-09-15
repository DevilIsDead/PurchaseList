using Microsoft.AspNetCore.Mvc;

namespace PurchaseList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        [HttpPost]
        public IActionResult Add([FromBody] string item)
        {
            Purchases.AddPurchase(item);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = Purchases.GetAllPurchases;
            return new JsonResult( result);
        }
    }
}