using SimpleInjector;

namespace knchrazo.Application.Dependencies
{
	public static class ContainerExtensions
	{
		public static void Load<TModuleType>(this Container container)
			where TModuleType : class, ISimpleInjectorModule, new()
		{
			var x = new TModuleType();
			x.Load(container);
		}
	}
}
