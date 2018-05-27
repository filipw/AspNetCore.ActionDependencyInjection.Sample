using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.ActionDependencyInjection.Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetController : ControllerBase
    {
        [HttpPost("hello")]
        public ActionResult<string> Post(RequestDto input, IHelloService svc)
            => svc.SayHello() + " " + input.Name;

        [HttpPost("bye")]
        public ActionResult<string> Post(RequestDto input, IGoodbyeService svc)
          => svc.SayGoodbye() + " " + input.Name;
    }

}
