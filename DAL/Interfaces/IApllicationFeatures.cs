using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IApllicationFeatures
    {
        List<Application> GetApplicationsStatus(string status);
        string Applicationtrack(int id);
    }
}
