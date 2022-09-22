using AutoMapper;
using CourierManagement.Areas.Admin.Models;
using CourierManagement.Training.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourierManagement.Profiles
{
    public class WebProfile : Profile
    {
        public WebProfile()
        {
            CreateMap<AddPickupModel, Pickup>().ReverseMap();
            CreateMap<AddTrackModel, Track>().ReverseMap();
        }
    }
}
