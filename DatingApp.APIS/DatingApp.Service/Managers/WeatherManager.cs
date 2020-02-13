using System;
using System.Linq;
using System.Collections.Generic;
using DatingApp.Core.Models;

namespace DatingApp.Service{

    public class WeatherManager :Contracts.IWeatherManager 
    {
        private readonly DatingApp.Repositories.Contracts.IUnitOfWork _UOF;
        public WeatherManager(DatingApp.Repositories.Contracts.IUnitOfWork UnitOfWork)
        {
            _UOF=UnitOfWork;
        }
        public IEnumerable<WeatherForecast> GetAll(){
            return _UOF.WeatherForecastRepository.Get().ToList();
        }
                
    }
}