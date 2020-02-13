using System;
using Microsoft.EntityFrameworkCore;
using DatingApp.Core.Models;
namespace DatingApp.Data
{
    
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        :base(options)
        {
            
        }
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        
    }
}
