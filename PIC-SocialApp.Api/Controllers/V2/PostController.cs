using Microsoft.AspNetCore.Mvc;

namespace PIC_SocialApp.Api.Controllers.V2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        //[HttpGet]
        //[Route("{id}")]
        //public IActionResult GetById(int id)
        //{
        //    var post = new Post { Id = id, Text = "Hello, Universe!" };
        //    return Ok(post);
        //}
    }
}
