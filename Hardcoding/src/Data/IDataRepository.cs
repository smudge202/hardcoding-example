using System.Collections.Generic;

namespace Data
{
	public interface IDataRepository
	{
		IEnumerable<string> Fetch();
	}
}
