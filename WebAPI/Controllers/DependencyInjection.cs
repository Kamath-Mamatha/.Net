using System;
using DI.BAL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class DependencyInjectionController : ControllerBase
    {
        private readonly IGetOutput _iGetOutput;

        public DependencyInjectionController(IGetOutput iGetOutput)
        {
            _iGetOutput = iGetOutput;
        }

        [HttpPost]
        public IActionResult GetOutputSource(string InputType)
        {
            return Ok(_iGetOutput.GetOutput(InputType));
        }
    }
}
