using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class Application
    {
        [Key]
        public int application_id { get; set; }
        [ForeignKey("Users")]
        public int user_id { get; set; }
        public string company_name { get; set; }
        public string position { get; set; }

        public DateTime date_applied { get; set; }
        public string status { get; set; }
        public string notes { get; set; }

        public virtual Users Users { get; set; }


    }
}
