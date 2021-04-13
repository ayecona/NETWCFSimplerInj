using CommonInstanceFactory.Extensions.Wcf;
using CommonInstanceFactory.Extensions.Wcf.SimpleInjector;
using knchrazo.Application.Dependencies;
using knchrazo.Application.Dependencies.Modules;
using SimpleInjector;
using System;
using System.ServiceModel;

namespace knchrazo.WCF.ServiceHostFactories
{
    public class SimpleInjectorServiceHostFactory : InjectedServiceHostFactory<Container>
	{
		protected override Container CreateContainer()
		{
			var container = new Container();
			container.Load<KnchrazoModule>();
			return container;
		}

		protected override ServiceHost CreateInjectedServiceHost
			(Container container, Type serviceType, Uri[] baseAddresses)
		{
			ServiceHost serviceHost = new SimpleInjectorServiceHost
				(container, serviceType, baseAddresses);
			return serviceHost;
		}
	}
}