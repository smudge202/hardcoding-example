using System.Collections.Generic;

namespace Data
{
	internal sealed class MockDatabaseRepository : IDataRepository
	{
		public IEnumerable<string> Fetch()
		{
			// Assume this was going to some arbitrary database and fetching data
			yield return "This data came from the database";
		}
	}
}
