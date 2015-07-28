using Microsoft.Framework.DependencyInjection;
using System.Collections.Generic;

namespace CommandLine
{
    internal static class ServiceExtensions
    {
		public static IServiceCollection AddCommandLine(this IServiceCollection services)
		{
			services.TryAdd(GetDefaultServices());
			return services;
		}

		public static IEnumerable<ServiceDescriptor> GetDefaultServices()
		{
			yield return ServiceDescriptor.Instance(System.Console.Out);
			yield return ServiceDescriptor.Transient<Data.IDataRepository, HardcodedData>();
			yield return ServiceDescriptor.Transient<DisplayData, DisplayData>();
		}
    }
}
