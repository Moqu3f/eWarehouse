namespace DAO.Repositories;

public interface IRepo<T>
{
    Task<long> AddAsync(T entity);
        
    Task<T> GetOneAsync(long id);

    Task<IEnumerable<T>> GetAllAsync();

    Task<int> DeleteAsync(long id);
        
    Task<int> SaveAsync(T entity);
}