using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using PIC_SocialApp.Domain.Models;

namespace PIC_SocialApp.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route(ApiRoutes.BaseRoute)]
    [ApiController]
    public class PostController : ControllerBase
    {
        [HttpGet]
        [Route(ApiRoutes.Posts.GetById)]
        public IActionResult GetById(int id)
        {
            //var post = new Post { Id = id, Text = "Hello, World!" };
            return Ok();
        }
    }
}
