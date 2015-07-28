using Microsoft.Framework.DependencyInjection;
using System.Collections.Generic;

namespace Data
{
	public static class ServiceExtensions
	{
		public static IServiceCollection AddDatabase(this IServiceCollection services)
		{
			services.TryAdd(GetDefaultServices());
			return services;
		}

		public static IEnumerable<ServiceDescriptor> GetDefaultServices()
		{
			yield return ServiceDescriptor.Transient<IDataRepository, MockDatabaseRepository>();
		}
	}
}
