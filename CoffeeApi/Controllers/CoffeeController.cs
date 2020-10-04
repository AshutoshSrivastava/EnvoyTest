using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoffeeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        private static readonly string[] Coffees = new[]
        {
            "Affogato","Americano","Caffe Latte","CafèAuLait","CAPPUCCINO","COLD BREW COFFEE","DOUBLE ESPRESSO (DOPPIO)","ESPRESSO","ESPRESSO CON PANNA","ESPRESSO MACCHIATO","FLAT WHITE","FRAPPÉ","IRISH COFFEE"
        };

        private readonly ILogger<CoffeeController> _logger;

        public CoffeeController(ILogger<CoffeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();
            return Ok(Coffees[rng.Next(Coffees.Length)]);

            // return Enumerable.Range(1, 5).Select(index => new Coffee
            // {
            //     Date = DateTime.Now.AddDays(index),
            //     TemperatureC = rng.Next(-20, 55),
            //     Summary = Summaries[rng.Next(Summaries.Length)]
            // })
            // .ToArray();
        }
    }
}
