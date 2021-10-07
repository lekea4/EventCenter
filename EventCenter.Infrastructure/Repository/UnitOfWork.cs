using EventCenter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCenter.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext _context;

        private IGenericRepository<EventPlace> _eventPlaces;

        private IGenericRepository<Location> _locations;

        public UnitOfWork(AppDBContext context)
        {
            _context = context;
        }
        public IGenericRepository<EventPlace> EventPlaces => _eventPlaces ??= new GenericRepository<EventPlace>(_context);
        public IGenericRepository<Location> Locations => _locations ??= new GenericRepository<Location>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
