using SimpleInjector;

namespace knchrazo.Application.Dependencies
{
	public interface ISimpleInjectorModule
	{
		void Load(Container container);
	}
}
