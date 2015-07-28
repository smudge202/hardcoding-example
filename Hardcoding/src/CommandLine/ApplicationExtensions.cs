using Compose;
using System;

namespace CommandLine
{
	internal static class ApplicationExtensions
	{
		public static void UseCommandLine(this Executable<int> app)
		{
			app.OnExecute<DisplayData>(displayData =>
			{
				try
				{
					return displayData.Run();
				}
				finally
				{
					Console.WriteLine("Press any key to exit...");
					Console.ReadKey();
				}
			});
		}
	}
}
