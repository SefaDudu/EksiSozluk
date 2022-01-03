﻿using Microsoft.Extensions.DependencyInjection;
using Project.Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers
            (this IServiceCollection serviceCollection,ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);
            }
            return ServiceTool.Create(serviceCollection);
        }
    }
}