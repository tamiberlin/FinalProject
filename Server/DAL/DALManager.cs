using DAL.DALApi;
using DAL.DALImplementation;
using DAL.DALModels1;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL;

public class DALManager
{
    public DALCostumerService Costumers { get; }

    public DALManager() 
    {
        ServiceCollection services = new();
        services.AddDbContext<Context>();
        services.AddScoped<IDALCostumerService, DALCostumerService>();

        ServiceProvider servicesProvider = services.BuildServiceProvider();
        Costumers = (DALCostumerService)servicesProvider.GetRequiredService<IDALCostumerService>();
    }
}
