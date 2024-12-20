using Magazine.BL.Profiles;
using Magazine.BL.Services.Abstractions;
using Magazine.BL.Services.Concretes;
using Magazine.DL.Contexts;
using Magazine.DL.Repositories.Abstractions;
using Magazine.DL.Repositories.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.BL.Extensions
{
    public static  class ServiceExtensionsForBL
    {
            public static void AddingServices(this IServiceCollection services)
            {
                services.AddScoped<IParticipantsService, ParticipantsService>();
                services.AddScoped<IWorkshopsService, WorkshopsService>();
                services.AddAutoMapper(typeof(ParcitipantsProfile).Assembly);
                services.AddAutoMapper(typeof(WorkShopsProfile).Assembly);

        }

        }
    }

