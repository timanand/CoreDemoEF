using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreDemoEF.Domain;

namespace CoreDemoEF.Data
{
    public interface IStaffRepository
    {
        List<StaffMember> GetAll();

        StaffMember GetById(int id);

        void Add(StaffMember staffMember);

        void Edit(StaffMember staffMember);

        void Delete(int id);


    }
}
