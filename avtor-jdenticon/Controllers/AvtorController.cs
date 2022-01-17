using Jdenticon;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace avtor_jdenticon.Controllers
{
    [ApiController]
    [Route("avtor")]
    public class IdenticonController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([Required] string value, int size = 100)
        {
            var identicon = Identicon.FromValue(value, size);

            using (var stream = identicon.SaveAsPng())
            {
                var buffer = new byte[stream.Length];
                stream.Read(buffer, 0, (int)stream.Length);
                var base64 = Convert.ToBase64String(buffer);
                return Ok(base64);
            }
        }
    }
}
