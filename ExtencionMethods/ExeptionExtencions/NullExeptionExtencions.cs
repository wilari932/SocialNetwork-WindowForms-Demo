using ExtencionMethods.BoolExtencions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtencionMethods.ExeptionExtencions
{
	public static class NullExeptionExtencions
	{
		public static void ThrowExeptionIfNull(this object value, string message) => (value == null).ThrowExeptionIfTrue(message);
		public static void ThrowExeptionIfNull(this object value, Exception exception) => (value == null).ThrowExeptionIfTrue(exception);
		public static bool IsNull(this object value) => (value == null);
	}
}
