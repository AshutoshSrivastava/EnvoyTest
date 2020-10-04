using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TeaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeaController : ControllerBase
    {
        private static readonly string[] Teas = new[]
        {
"Cardamom tea",
"Green tea.",
"Oolong Tea.",
"Matcha.",
"White Tea.",
"Pu-erh.",
"Yellow tea.",
"Mulberry black tea.",
"Chai.",
"Barley tea",
"Camomile tea",
"Chrysanthemum tea",
"Hibiscus tea",
"Honey tea",
"Mint ginger lemon tea",
"Peppermint",
"Rooibos / Lemon Rooibos",
"Rosehip tea",
"Spearmint tea",
"Tulsi or Holy Basil tea",
"Yerba Mate"
        };

        private readonly ILogger<TeaController> _logger;

        public TeaController(ILogger<TeaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();
            return Ok(Teas[rng.Next(Teas.Length)]);
            
            // return Enumerable.Range(1, 5).Select(index => new Tea
            // {
            //     Date = DateTime.Now.AddDays(index),
            //     TemperatureC = rng.Next(-20, 55),
            //     Summary = Summaries[rng.Next(Summaries.Length)]
            // })
            // .ToArray();
        }
    }
}
