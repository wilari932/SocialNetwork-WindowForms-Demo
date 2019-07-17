using DataBaseLayer.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLayer
{
	public class DataBaseContext : DbContext
	{

		public DataBaseContext() : base("Default")
		{
			Database.SetInitializer<DataBaseContext>(new CreateDatabaseIfNotExists<DataBaseContext>());
		}
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			
		
			modelBuilder.Entity<User>().ToTable(nameof(User));


		}
	}
}
