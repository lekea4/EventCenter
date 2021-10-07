using EventCenter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCenter.Infrastructure.Repository
{
    public interface IUnitOfWork : IDisposable
    {

        IGenericRepository<EventPlace> EventPlaces { get; }

        IGenericRepository<Location> Locations { get; }

        Task Save();
    }
}
