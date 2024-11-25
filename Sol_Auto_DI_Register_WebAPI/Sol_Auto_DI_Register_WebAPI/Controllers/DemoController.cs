using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sol_Auto_DI_Register_WebAPI.Services;

namespace Sol_Auto_DI_Register_WebAPI.Controllers
{
    [Route("api/demo")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IScopedDemo _scopedDemo;

        public DemoController(IScopedDemo scopedDemo)
        {
            _scopedDemo = scopedDemo;
        }

        [HttpGet]
        public string Get()
        {
            _scopedDemo.DoSomething();
            return "Hello World";
        }
    }
}