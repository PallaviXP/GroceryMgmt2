using GroceryServices.DAL;
using GroceryServices.Service;
using Microsoft.Extensions.DependencyInjection;

namespace GroceryServices
{
    public static class ServiceInjector
    {
        public static IServiceCollection RegisterServices(
            this IServiceCollection services)
        {


            //Singleton - This implies only a single instance will be created and shared by all consumers.
            //example:- services.AddSingleton<IGroceryService, GroceryService>();

            //Scoped - This implies that one instance per scope (i.e., one instance per request to the application) will be created.
            //example :- services.AddScoped<IGroceryService, GroceryService>();

            //Transient: This implies that the components will not be shared but will be created each time they are requested.
            services.AddTransient<IGroceryService, GroceryService>();
            services.AddTransient(typeof(IDBCommunicator<>),typeof(DBCommunicator<>));

            return services;
        }
    }
}
