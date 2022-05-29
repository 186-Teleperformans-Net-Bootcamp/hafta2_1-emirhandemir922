using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Teleperformance._2.StockManagement;

namespace Teleperformance._2
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IProducts _product;
        public HomeController(IProducts product)
        {
            _product = product;
        }

        public IActionResult Index() 
        {
            _product.calculateStock(_product.id);
            return Ok();
        }
    }
}
