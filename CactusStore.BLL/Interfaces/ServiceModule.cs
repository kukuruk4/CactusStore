using CactusStore.DAL.Interfaces;
using CactusStore.DAL.Repositories;
using Ninject.Modules;
using NLayerApp.DAL.Repositories;

namespace CactusStore.BLL.Interfaces
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}