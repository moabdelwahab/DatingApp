using DatingApp.Repositories.Contracts;
using DatingApp.Repositories.Repositories;
using DatingApp.Core.Models;

namespace DatingApp.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private DatingApp.Data.DataContext _context;

        private GenericRepository<WeatherForecast> _weatherForecostRepo;
        public UnitOfWork(DatingApp.Data.DataContext context)
        {
            _context=context;
        }
        
        public GenericRepository<WeatherForecast> WeatherForecastRepository 
        { 
         get {
                if(_weatherForecostRepo==null)
                this._weatherForecostRepo = new GenericRepository<WeatherForecast>(_context);
                return _weatherForecostRepo;
            }
         }

        public void Dispose()
        {
           this._context.Dispose();
        }
    }
}