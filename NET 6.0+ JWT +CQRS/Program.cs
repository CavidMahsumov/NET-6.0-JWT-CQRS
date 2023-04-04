using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NET_6._0__JWT__CQRS.Core.Application.Interfaces;
using NET_6._0__JWT__CQRS.Core.Application.Mappings;
using NET_6._0__JWT__CQRS.Persistance.Context;
using NET_6._0__JWT__CQRS.Persistance.Repositories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ProjectJwtContext>(opt => {
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Local")); 
});

builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(opt =>
{
    opt.AddProfiles(new List<Profile>()
    {
        new ProductProfile()
    });

});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
