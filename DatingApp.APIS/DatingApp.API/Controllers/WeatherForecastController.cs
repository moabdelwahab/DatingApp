using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace DatingApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly DatingApp.Service.Contracts.IWeatherManager _weatherManager;
    
        public WeatherForecastController(DatingApp.Service.Contracts.IWeatherManager manager)
        {
            _weatherManager=manager;
        }
     
        [HttpGet]
        public  IActionResult Get()
        {
            return Ok(_weatherManager.GetAll().ToList()); 
        }
    }
}
