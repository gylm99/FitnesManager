﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnesManager.Infrastructure
{
    public static class DependenyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services) 
        {
            return services;
        }
    }
}
