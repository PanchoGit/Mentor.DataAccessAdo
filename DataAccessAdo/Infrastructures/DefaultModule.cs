using System.Reflection;
using Autofac;
using Module = Autofac.Module;

namespace DataAccessAdo.Infrastructures
{
    public class DefaultModule : Module
    {
        private const string RepositoryAssemblyEndName = "Repository";

        protected override void Load(ContainerBuilder builder)
        {
            var assemblies = Assembly.Load(nameof(DataAccessAdo));

            builder.RegisterAssemblyTypes(assemblies)
                .Where(s => s.Name.EndsWith(RepositoryAssemblyEndName))
                .AsImplementedInterfaces();
        }
    }
}
