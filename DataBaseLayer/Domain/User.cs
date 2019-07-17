using DataBaseLayer.GenericRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLayer.Domain
{
	public class User:BaseEntity
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Key]
		public Guid Id { get; set; }

		[Index("Key_UserName", 1, IsUnique = true)]
		[MinLength(3)]
		[MaxLength(20)]
		public string UserName { get; set; }
		[Required]
		[MinLength(3)]
		public string UserNameNormalized { get; set; }
		[Required]
		public byte[] HashedPassword { get; set; }
	}
}
