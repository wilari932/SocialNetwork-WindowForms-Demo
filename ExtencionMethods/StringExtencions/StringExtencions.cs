using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtencionMethods.StringExtencions
{
	public static class StringExtencions
	{
		public static bool IsBlanktOrNull(this string value)
		{
			return (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value));
		}
	}
}
