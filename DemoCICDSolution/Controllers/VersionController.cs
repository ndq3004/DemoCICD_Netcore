using Microsoft.AspNetCore.Mvc;

namespace DemoCICDSolution.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VersionController : ControllerBase
    {
        private IConfiguration Configuration;
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching1223456"
    };

        //private readonly ILogger<WeatherForecastController> _logger;

        public VersionController(IConfiguration configuration)
        {
            //_logger = logger;
            Configuration = configuration;
        }

        [HttpGet(Name = "Version")]
        public string Get()
        {
            return $"<h1>Current version is {Configuration["Version"]}</h1>";
        }
    }
}
