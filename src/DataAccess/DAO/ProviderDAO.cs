using System.Collections.Generic;
using System.Linq;
using DataAccess.Context;
using DataAccess.Interfaces;
using Models;

namespace eWarehouse.DataAccess.DAO
{
    public class ProviderDAO : IProviderDAO
    {
        private readonly eWarehouseDbContext _context;

        public ProviderDAO(eWarehouseDbContext context)
        {
            _context = context;
        }

        public void Create(Provider provider)
        {
            _context.Providers.Add(provider);
            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var provider = _context.Providers.Find(id);
            _context.Providers.Remove(provider);
            _context.SaveChanges();
        }

        public List<Provider> GetAll()
        {
            return _context.Providers.ToList();
        }

        public Provider GetById(long id)
        {
            return _context.Providers.Find(id);
        }

        public void Update(Provider provider)
        {
            _context.Providers.Update(provider);
            _context.SaveChanges();
        }
    }
}