using AutoMapper;
using PZS.Core.Models;
using PZS.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZS.Service.AutoMapperProfile
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AccountDTO, Account>().ReverseMap();
        }
    }
}
