using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ApplicationService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Application, ApplicationDTO>();
                cfg.CreateMap<ApplicationDTO, Application>();
                cfg.CreateMap<Application, ApplicationUserDTO>();     
            });
            return new Mapper(config);
        }
        public static List<ApplicationDTO> GetApplications() { 

            var repo = DataAccessFactory.getApplications();
            return GetMapper().Map<List<ApplicationDTO>>(repo.GetALL());
        
        }
    }
}
