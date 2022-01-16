using Microsoft.Extensions.DependencyInjection;
using MVCCoreWeb.Interfaces;
using MVCCoreWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreWeb.Dependesies
{
    public static class ServiceDependencies
    {
        public static void AddServicesDependencies( this IServiceCollection service)
        {
            service.AddTransient<IUser, UserServices>();
        }
             
    }
}
