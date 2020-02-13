using System.Collections.Generic;

namespace DatingApp.Service.Contracts
{
    public interface IWeatherManager
    {
        IEnumerable<DatingApp.Core.Models.WeatherForecast>  GetAll();
    }
}