using BL.BLApi;
using BL.BLImplementation;
using BL.BLModels;
using DAL.DALApi;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL;

public class BLManager
{
    public BLCostumerService BLCostumer { get; }

    public BLManager()
    {
        ServiceCollection services = new();
        services.AddScoped<BLCostumer>();
        services.AddScoped<IBLCostumerService, BLCostumerService>();
        ServiceProvider servicesProvider = services.BuildServiceProvider();
        BLCostumer = servicesProvider.GetRequiredService<BLCostumerService>();
    }
}
