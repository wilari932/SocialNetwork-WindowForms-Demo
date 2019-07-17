using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace DataBaseLayer.GenericRepository
{
	public class Repository<T> : IRepository<T> where T : BaseEntity
	{

		public async Task<T> CrateAsync(T entity)
		{
			using (var context = new DataBaseContext())
			{

				var value = context.Set<T>().Add(entity);
				await context.SaveChangesAsync();
				return value;

			}
		}

		public async Task DeleteAsync(T entity)
		{
			using (var context = new DataBaseContext())
			{
				var value = context.Set<T>().Remove(entity);
				await context.SaveChangesAsync();

			}
		}

		public async Task<T> GetAsync(Expression<Func<T, bool>> expression)
		{
			using (var context = new DataBaseContext())
			{
				var value = await context.Set<T>().Where(expression).FirstOrDefaultAsync();
				return value;
			}


		}

		public async Task<ICollection<T>> GetAll(Expression<Func<T, bool>> expression)
		{
			using (var context = new DataBaseContext())
			{
				var value = await context.Set<T>().Where(expression).ToListAsync();
				return value;
			}
		}

		public async Task<T> UpdateAsync(T entity)
		{
			using (var context = new DataBaseContext())
			{
				var value = context.Set<T>().Add(entity);
				context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
				await context.SaveChangesAsync();
				return value;
			}
		}
	}
}
