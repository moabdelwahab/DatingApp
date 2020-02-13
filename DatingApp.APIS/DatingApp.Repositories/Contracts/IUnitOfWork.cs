using System;
using DatingApp.Core.Models;
using DatingApp.Repositories.Repositories;

namespace DatingApp.Repositories.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
      GenericRepository<WeatherForecast> WeatherForecastRepository { get; }
       
    }
}