using BLL.Models;
using eWarehouse.BLL.Interfaces;
using eWarehouse.DAO.Database;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DAO.Repositories
{
    public abstract class BaseRepo<T> : IRepo<T> where T : class , IIdentifiable, new()
    {
        public BaseRepo(WarehouseContext context)
        {
            Context = context;
        }

        public WarehouseContext Context { get; init; }

        protected DbSet<T> Table;

        public async Task<long> AddAsync(T entity)
        {
            await Table.AddAsync(entity);
            await SaveChangesAsync();
            return entity.Id;
        }

        
        public async Task<int> DeleteAsync(long id)
        {
            var entity = await GetOneAsync(id);

            if (entity != null)
            {
                Context.Entry(entity).State = EntityState.Deleted;
                return await SaveChangesAsync();
            }

            return 0;
        }
        

        public virtual async Task<IEnumerable<T>> GetAllAsync() => await Table.ToListAsync();

        public virtual async Task<T> GetOneAsync(long id) => await Task.Run(() => Table.FirstOrDefault(entity => entity.Id == id));

        public async Task<int> SaveAsync(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return await SaveChangesAsync();
        }

        internal async Task<int> SaveChangesAsync()
        {
            try
            {
                return await Context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            catch (DbUpdateException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }



}