using Microsoft.Extensions.DependencyInjection;
using StringReverseDemo.Services.Implementation;
using StringReverseDemo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseDemo.DAL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccessLayer(this IServiceCollection services)
        {
            services.AddTransient<IDataRepository, DataRepository>();
            return services;
        }
    }
}
