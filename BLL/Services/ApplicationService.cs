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

        public static ApplicationDTO UpdateApplicationStatus(int appId, string newStatus)
        {
            var repo = DataAccessFactory.getApplications();
            var application = repo.GetbyID(appId);

            if (application == null)
                return null;

            string oldStatus = application.status;

            application.status = $"{oldStatus} -> {newStatus}";

            repo.Update(application);

            return GetMapper().Map<ApplicationDTO>(application);
        }
        public static string Applicationtrack(int id)
        {
            var repo = DataAccessFactory.applicationTrack();
            if (repo == null) return "Application not found";
            return repo.Applicationtrack(id);
        }
        public static ApplicationDTO AddApplicationNotes(int appId, string newNotes)
        {
            var repo = DataAccessFactory.getApplications();
            var application = repo.GetbyID(appId);

            if (application == null)
                return null;

            application.notes = newNotes;

            repo.Update(application);

            return GetMapper().Map<ApplicationDTO>(application);
        }
        public static List<ApplicationDTO> ApplicationWithDeadline()
        {
            var repo = DataAccessFactory.deadlineFeature();
            return GetMapper().Map<List<ApplicationDTO>>(repo.ApplicationWithDeadlines());
        }
    }

  }
