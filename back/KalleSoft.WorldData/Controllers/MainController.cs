using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KalleSoft.WorldData.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace KalleSoft.WorldData.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {

        private readonly ILogger<MainController> _logger;
        public MainController(ILogger<MainController> logger)
        {
            this._logger = logger;
        }

        protected ActionResult CustomResponse(object? data, bool isCreated = false)
        {
            _logger.LogTrace("rastro!");

            try
            {
                if (data == null)
                    return NotFound(data);

                if (isCreated)
                    return Created("", data);

                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(exception: ex, message: ex.Message);
                return new ObjectResult("Internal Error") { StatusCode = StatusCodes.Status500InternalServerError };
            }



        }
    }
}