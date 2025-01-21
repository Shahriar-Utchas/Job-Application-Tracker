using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ApplicationRepo :RepoDB, IRepo<Application, int, Application>, IApllicationFeatures
    {
        public Application ADD(Application obj)
        {
            db.Applications.Add(obj);
            db.SaveChanges();
            return obj;

        }

        public string Applicationtrack(int id)
        {
            var obj = db.Applications.Find(id);
            if (obj == null) return "Status not found";
            return obj.status;
        }

        public bool Delete(int id)
        {
            var obj = db.Applications.Find(id);
            if(obj == null) return false;
            db.Applications.Remove(obj);
            return db.SaveChanges() > 0;
        }

        public List<Application> GetALL()
        {
            return db.Applications.ToList();
        }

        public List<Application> GetApplicationsStatus(string s)
        {
            return db.Applications.Where(x => x.status == s).ToList();
        }

        public Application GetbyID(int id)
        {
            return db.Applications.Find(id);
        }

        public Application Update(Application obj)
        {
            var exobj = db.Applications.Find(obj.application_id);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return obj;
        }
    }
}
