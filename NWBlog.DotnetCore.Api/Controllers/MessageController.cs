using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace NWBlog.DotnetCore.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/message")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        /// <summary>
        /// Gets message by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<List<Message>> Get(int id)
        {
            return Ok(new Message
            {
                Id = id,
                Text = "Hello world"
            });
        }
    }

    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
