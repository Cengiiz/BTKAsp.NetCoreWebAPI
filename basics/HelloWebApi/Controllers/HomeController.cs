using HelloWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWebApi.Controllers
{
    [ApiController]
    [Route("/home")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            var result= new ResponseModel()
            {
                HttpStatus = 200,
                Message = "Hello"
            };
            return Ok(result);
        }
    }
}
