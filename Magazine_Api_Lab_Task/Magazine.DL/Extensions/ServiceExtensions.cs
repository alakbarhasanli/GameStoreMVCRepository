using Magazine.DL.Contexts;
using Magazine.DL.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.DL.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddingServices(this IServiceCollection services) 
        {
            services.AddDbContext<MagazineDbContext>(opt=>opt.UseSqlServer(ConnectionStr.ConnectionString()));
        }
    }
}
