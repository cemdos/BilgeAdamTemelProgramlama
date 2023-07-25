using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.BLL.Common
{
	public enum ResponseType
	{
		None,
		DbError,
		ServiceError,
		ValidationError
	}
}
