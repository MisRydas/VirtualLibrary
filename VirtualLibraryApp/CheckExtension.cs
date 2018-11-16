using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CheckExtensions
{
	public static class CheckExtension
	{
		static Regex regex;

		public static bool CheckISBN13(string ISBN13)
		{
			regex = new Regex(@"^\d{13}$");

			if (regex.IsMatch(ISBN13))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static bool CheckISBN10(string ISBN10)
		{
			Regex regex;
			regex = new Regex(@"^$|^\d{10}$");
			if (regex.IsMatch(ISBN10))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static bool CheckPublished(string published)
		{
			Regex regex;
			regex = new Regex(@"^([1-2]{1})(\d{3})$");
			if (regex.IsMatch(published))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
