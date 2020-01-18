using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace BattleShip.Controllers
{
    [Route("error")]
    public class ErrorController : Controller
    {
        [HttpGet]
        [HttpPost]
        [HttpPut]
        [HttpDelete]
        public IActionResult Error()
        {
            var errorResponse = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var exception = errorResponse?.Error;

            return exception != null ? StatusCode((int)HttpStatusCode.InternalServerError) : Ok();
        }
    }
}