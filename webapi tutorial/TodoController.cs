using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace webapi_tutorial
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly IMyDependency dependency;

        public TodoController(IMyDependency dependency)
        {
            this.dependency = dependency;
        }

        [HttpGet]
        public string Index()
        {
            this.dependency.WriteMessage("Can u see me?");
            return "Hello World";
        }
    }
}
