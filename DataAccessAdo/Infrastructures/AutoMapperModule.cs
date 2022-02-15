using Autofac;
using AutoMapper;
using DataAccessAdo.Mappers;

namespace DataAccessAdo.Infrastructures
{
    public class AutoMapperModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            var profiles = typeof(SkaterMapperProfile).Assembly.GetTypes()
                .Where(x => typeof(Profile).IsAssignableFrom(x)).ToList();

            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                foreach (var profile in profiles)
                {
                    cfg.AddProfile(profile);
                }
            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>();
        }
    }
}
