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
            Bind<ICommentReportService>().To<ICommentReportManager>();
            Bind<ICommentReportDal>().To<EfCommentReportDal>();
            Bind<ICommentService>().To<CommentManager>();
            Bind<ICommentDal>().To<EfCommentDal>();
            Bind<ICommentVoteService>().To<CommentVoteManager>();
            Bind<ICommentVoteDal>().To<EfCommentVoteDal>();

            Bind<ISubjectService>().To<SubjectManager>();
            Bind<ISubjectDal>().To<EfSubjectDal>();
            Bind<IUserReportService>().To<UserReportManager>();
            Bind<IUserReportDal>().To<EfUserReportDal>();

            Bind<IRoleService>().To<RoleManager>();
            Bind<IRoleDal>().To<EfRoleDal>();
        }
    }
}