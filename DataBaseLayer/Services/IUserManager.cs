using DataBaseLayer.Domain;
using DataBaseLayer.GenericRepository;
using ExtencionMethods.BoolExtencions;
using ExtencionMethods.ExeptionExtencions;
using ExtencionMethods.StringExtencions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLayer.Services
{

	


	
	public class UserManager: IUserManager
	{
		private readonly IRepository<User> repository;
		public UserManager()
		{
			repository = new Repository<User>();
		}
		public async Task CreateUserAsync(string userName, string Password)
		{
			if (userName.IsBlanktOrNull() || Password.IsBlanktOrNull())
				throw new Exception("Username or password invalid formart");
			PasswordHash hash = new PasswordHash(Password);
			var hasbyte = hash.ToArray();
			
			await repository.CrateAsync(new User { Id= Guid.NewGuid(), HashedPassword = hasbyte,UserName = userName.Trim(), UserNameNormalized = userName.Trim().ToUpper() });
		}

		
		public async Task<bool> LoginAsyc(string userName, string password )
		{
			(userName.IsBlanktOrNull()
			|| password.IsBlanktOrNull()).ThrowExeptionIfTrue("Username or password invalid formart");
		

			var result = await repository.GetAsync(x=> x.UserNameNormalized == userName.Trim().ToUpper());

			result.ThrowExeptionIfNull("Wrong Credentials!");


			byte[] hashBytes = result.HashedPassword;

			PasswordHash hash = new PasswordHash(hashBytes);
			(!hash.Verify(password)).ThrowExeptionIfTrue("Wrong Credentials!");

			return hash.Verify(password);


		}
	}
	public interface IUserManager
	{
		Task CreateUserAsync(string userName, string Password);
		Task<bool> LoginAsyc(string userName, string Password);
	}
}
