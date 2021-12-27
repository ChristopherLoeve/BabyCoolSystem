using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestCareService.Managers;
using RestCareService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestCareService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BabiesController : ControllerBase
    {
        private static readonly BabiesManager _mgr = new BabiesManager();

        // GET: api/<BabiesController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _mgr.GetAllAsync());
        }

        // POST api/<BabiesController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> PostAsync([FromBody] BabyData newData)
        {
            newData.Id = 0;
            return Ok(await _mgr.InsertDataAsync(newData));
        }

    }
}
