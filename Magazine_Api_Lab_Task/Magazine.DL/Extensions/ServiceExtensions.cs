using Magazine.DL.Contexts;
using Magazine.DL.Helpers;
using Magazine.DL.Repositories.Abstractions;
using Magazine.DL.Repositories.Concretes;
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
        public static void AddingRepositoryandServices(this IServiceCollection services) 
        {
            services.AddDbContext<MagazineDbContext>(opt=>opt.UseSqlServer(ConnectionStr.ConnectionString()));
            services.AddScoped<IPartipicatiansRepository, PartipicatiansRepository>();
            services.AddScoped<IWorkshopsRepository, WorkshopsRepository>();
            


        }
     
    }
    
}
