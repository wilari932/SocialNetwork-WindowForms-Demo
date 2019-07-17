using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtencionMethods.BoolExtencions
{
	public static class BoolExtencios
	{
		public static void ThrowExeptionIfTrue(this bool value, string message) => ThrowExeptionIfTrue(value, new Exception(message));
		
		public  static void ThrowExeptionIfTrue(this bool value, Exception e)
		{
			if (value)
				throw e;
		}
	}
}
