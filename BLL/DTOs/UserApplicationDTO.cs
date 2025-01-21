using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UserApplicationDTO: UserDTO
    {
        public  List<Application> Applications { get; set; }
        public UserApplicationDTO()
        {
            Applications = new List<Application>();

        }
    }
}
