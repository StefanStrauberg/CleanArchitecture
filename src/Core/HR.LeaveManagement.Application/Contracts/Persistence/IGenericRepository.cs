namespace HR.LeaveManagement.Application.Contracts.Persistence;

public interface IGenericRepository<T> where T : BaseEntity
{
  Task<T> GetAsync();
  Task<T> GetByIdAsync(Guid Id);
  Task<T> CreateAsync(T entity);
  Task<T> UpdateAsync(T entity);
  Task<T> DeleteAsync(T entity);
}
