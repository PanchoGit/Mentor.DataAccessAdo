using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using DataAccessAdo.Infrastructures;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(s =>
{
    s.RegisterModule(new DefaultModule());
    s.RegisterModule(new AutoMapperModule());
    s.RegisterModule(new DatabaseModule(builder.Configuration));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
