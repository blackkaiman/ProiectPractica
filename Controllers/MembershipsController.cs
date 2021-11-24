﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProiectPractica.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MembershipsController : ControllerBase
    {
        private readonly ILogger<MembershipsController> _logger;

        public MembershipsController(ILogger<MembershipsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get() //citeste date din tabel
        {
            return StatusCode(200);

        }

        [HttpPost]
        public IActionResult Post() //adauga inregistrare in tabel
        {
            return StatusCode(200);
        }

        [HttpPut]
        public IActionResult Put() //updateaza inregistrare in tabel
        {
            return StatusCode(200);
        }

        [HttpDelete]
        public IActionResult Delete() //sterge inregistrare in tabel
        {
            return StatusCode(200);
        }
    }
}
