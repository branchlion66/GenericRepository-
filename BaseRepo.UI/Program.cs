// See https://aka.ms/new-console-template for more information

using BaseRepo.Data;
using BaseRepo.Repository.Developers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using BaseRepo.Service.Developers;

Console.WriteLine("Hello, World!");

var serviceProvider = ServiceInitialization();
var developerService = serviceProvider.GetService<IDeveloperService>();
var result = developerService.Developers();
var x = 10; 

static ServiceProvider ServiceInitialization()
{
    return new ServiceCollection()
        .AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(@"Server=.;Database=DeveloperDB;Trusted_Connection=True;");
        })
        .AddSingleton<IDeveloperRepository, DeveloperRepository>()
        .AddSingleton<IDeveloperService, DeveloperService>()
        .BuildServiceProvider();
    
}

