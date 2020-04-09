﻿using AutoMapper;
using BookStore.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Mvc.Configurations
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMappings();
        }
    }
}
