using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyBasket.Api.Services;

namespace SurveyBasket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevelopmentController : ControllerBase
    {
        private readonly IOS _os;

        public DevelopmentController(IOS ios)
        {
            _os = ios;
        }

        [HttpGet]

        public IActionResult Run()
        {
            var message = _os.RunApp();
            return Ok(message);
        }
    }
}
