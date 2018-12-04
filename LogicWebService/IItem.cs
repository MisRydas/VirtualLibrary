using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogicWebService
{
	public interface IItem
	{
		String TableName();
		String TypesInString();
		String ValuesInString();
	}
}