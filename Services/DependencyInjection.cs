using Microsoft.Extensions.DependencyInjection;
using StringReverseDemo.Services.Implementation;
using StringReverseDemo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseDemo.BLL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBusinessLayer(this IServiceCollection services)
        {
            services.AddTransient<IStringReverseService, StringReverseService>();
            return services;
        }
    }
}
