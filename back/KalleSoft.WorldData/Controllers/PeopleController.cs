using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KalleSoft.WorldData.Application.Interfaces;
using KalleSoft.WorldData.Domain.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace KalleSoft.WorldData.Controllers
{
    public class PeopleController : MainController
    {
        private readonly IPeopleService _service;
        public PeopleController(ILogger<PeopleController> logger, IPeopleService service) : base(logger)
        {
            _service = service;
        }

        [HttpGet()]
        public async Task<IActionResult> Get()
        {

            return CustomResponse(await _service.GetAllAsync());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetById([FromRoute] string id)
        {

            return CustomResponse(await _service.GetByIdAsync(id));
        }

        [HttpPost()]
        public async Task<IActionResult> Post([FromBody] Person model)
        {

            return CustomResponse(await _service.InsertAsync(model));
        }

        [HttpPut("id")]
        public async Task<IActionResult> Put([FromBody] Person model, [FromRoute] string id)
        {

            return CustomResponse(await _service.UpdateAsync(model, id));
        }

        [HttpDelete("id:guid")]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {

            return CustomResponse(await _service.DeleteAsync(id));
        }
    }
}