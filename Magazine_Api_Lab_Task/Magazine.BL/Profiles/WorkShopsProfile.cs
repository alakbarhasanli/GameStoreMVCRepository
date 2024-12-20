using AutoMapper;
using Magazine.BL.DTOs;
using Magazine.DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.BL.Profiles
{
    public class WorkShopsProfile:Profile
    {
        public WorkShopsProfile()
        {
            CreateMap<WorkShopsCreateDTO, WorkShops>();
            CreateMap<WorkShopsCreateDTO, WorkShops>().ReverseMap();
        }
    }
}
