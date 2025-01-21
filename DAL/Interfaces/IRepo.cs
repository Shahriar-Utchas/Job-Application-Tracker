using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<CLASS, ID, RETURN>
    {
        List<CLASS> GetALL();
        RETURN GetbyID(ID id);
        RETURN ADD(CLASS obj);
        RETURN Update(CLASS obj);
        bool Delete(ID id);


    }
}
