using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ApplicationDTO
    {
        public int application_id { get; set; }
        public int user_id { get; set; }
        public string company_name { get; set; }
        public string position { get; set; }

        public DateTime date_applied { get; set; }
        public string status { get; set; }  
        public string notes { get; set; }
        public DateTime? deadline { get; set; }

    }
}
