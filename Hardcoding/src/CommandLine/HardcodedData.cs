using System.Collections.Generic;
using Data;

namespace CommandLine
{
	internal sealed class HardcodedData : IDataRepository
	{
		public IEnumerable<string> Fetch()
		{
			yield return "This data is hardcoded";
		}
	}
}
