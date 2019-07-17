using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLayer.GenericRepository
{
	public class BaseEntity
	{

	}
	public interface IRepository<T> where T: BaseEntity
	{
		Task<T> CrateAsync(T entity);
		Task<T> UpdateAsync(T entity);
		Task DeleteAsync(T entity);
		Task<ICollection<T>> GetAll(Expression<Func<T, bool>> expression);
		Task<T> GetAsync(Expression<Func<T, bool>> expression);
	}
}
