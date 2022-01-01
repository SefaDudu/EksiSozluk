using Ninject.Modules;
using Project.Business.Abstract;
using Project.Business.Concrete;
using Project.DataAccess.Abstract;
using Project.DataAccess.Concrete.EntityFramework;

namespace Project.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {

            Bind<IUserService>().To<UserManager>();
            Bind<IUserDal>().To<EfUserDal>();
            Bind<IBlacklistService>().To<BlacklistManager>();
            Bind<IBlacklistDal>().To<EfBlacklistDal>();
        }
    }
}