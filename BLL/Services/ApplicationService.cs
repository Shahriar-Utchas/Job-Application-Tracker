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
        public static ApplicationDTO AddApplication(ApplicationDTO app)
        {
            var repo = DataAccessFactory.getApplications();
            var data = GetMapper().Map<Application>(app);
            return GetMapper().Map<ApplicationDTO>(repo.ADD(data));
        }

        public static List<ApplicationDTO> GetApplications()
        {

            var repo = DataAccessFactory.getApplications();
            return GetMapper().Map<List<ApplicationDTO>>(repo.GetALL());

        }
        public static ApplicationDTO GetApplication(int id)
        {
            var repo = DataAccessFactory.getApplications();
            return GetMapper().Map<ApplicationDTO>(repo.GetbyID(id));
        }
        public static ApplicationDTO UpdateApplication(ApplicationDTO app)
        {
            var repo = DataAccessFactory.getApplications();
            var data = GetMapper().Map<Application>(app);
            return GetMapper().Map<ApplicationDTO>(repo.Update(data));
        }
        public static bool DeleteApplication(int id)
        {
            var repo = DataAccessFactory.getApplications();
            return repo.Delete(id);
        }
        
        public static Dictionary<string, object> UserApplicationDetails(int id)
        {
            var repo = DataAccessFactory.getApplications();
            var data = repo.GetbyID(id);
            if (data == null)
            {
                return null;
            }
            var userData = new Dictionary<string, object>
                {
                    { "company_name", data.company_name },
                    { "position", data.position },
                    { "date_applied", data.date_applied },
                    { "status", data.status }
                };

            return userData;

        }
        public static List<ApplicationDTO> GetApplicationsStatus(string s)
        {
            var repo = DataAccessFactory.applicationStatus();
            return GetMapper().Map<List<ApplicationDTO>>(repo.GetApplicationsStatus(s));
        }
    }
}
