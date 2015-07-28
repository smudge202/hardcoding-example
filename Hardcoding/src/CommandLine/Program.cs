using Compose;
using Data;

namespace CommandLine
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var app = new CommandLineApplication();
			app.UseServices(services =>
			{
				services
					// TODO: Uncomment the following line to switch from hardcoded to a (mocked) database
					// without changing any consumer code
					//.AddDatabase()
					.AddCommandLine();
			});
			app.UseCommandLine();
			app.Execute();
        }
    }
}
