using AutoMapper;
using knchrazo.Application.Automapper;
using knchrazo.Application.Repository;
using knchrazo.Application.Repository.IRepository;
using knchrazo.Application.Services;
using knchrazo.Application.Services.IService;
using knchrazo.Infrastructure;
using knchrazo.Infrastructure.Interfaces;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace knchrazo.Application.Dependencies.Modules
{
    public class KnchrazoModule : ISimpleInjectorModule
    {
        public void Load(Container container)
        {
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            container.Register<IApplicationDbContext, ApplicationDbContext>(Lifestyle.Singleton);

            container.Register<MapperProvider, MapperProvider>();
            container.RegisterSingleton(() => GetMapper(container));

            container.Register<IEmployeeManagerRepository, EmployeeManagerRepository>();
            container.Register<EmployeeManagerRepository>();
            container.Register<IEmployeeManagerService, EmployeeManagerService>();
            container.Register<EmployeeManagerService>();

        }

        private IMapper GetMapper(Container container)
        {
            var mp = container.GetInstance<MapperProvider>();
            return mp.GetMapper();
        }
    }
}
