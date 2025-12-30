using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsermanagementController : ControllerBase
    {




        [HttpGet("getName")]
        public List<string> getName()
        {


            return new List<string>();
        }
    }
}
