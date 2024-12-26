﻿using Ecommers.DAL.Contexts;
using Ecommers.DAL.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommers.DAL.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServiceRepostories(this IServiceCollection services)
        {
            services.AddDbContext<EcommerseDbContext>(opt => opt.UseSqlServer(GetConnectionStr.GetConnection()));
        }

    }
}