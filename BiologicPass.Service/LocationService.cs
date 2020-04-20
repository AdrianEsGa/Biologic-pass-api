using System;
using System.Collections.Generic;
using System.Linq;
using BiologicPass.Data;
using BiologicPass.Model.Entities;

namespace BiologicPass.Service
{
    public class LocationService : ILocationService
    {
        private readonly BiologicPassDbContext _biologicPassDbContext;

        public LocationService(BiologicPassDbContext biologicPassDbContext)
        {
            _biologicPassDbContext = biologicPassDbContext;
        }

        public IEnumerable<Location> GetAll()
        {
            try
            {
                return _biologicPassDbContext.Locations.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public object Add(Location location)
        {
            throw new NotImplementedException();
        }
    }

    public interface ILocationService
    {
        IEnumerable<Location> GetAll();
        object Add(Location location);
    }
}
