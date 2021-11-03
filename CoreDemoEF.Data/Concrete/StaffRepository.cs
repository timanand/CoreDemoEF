using CoreDemoEF.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreDemoEF.Data

{
    public class StaffRepository : IStaffRepository
    {
        private readonly StaffContext _context;


        // Constructor
        public StaffRepository(StaffContext context)
        {
            _context = context;
        }


        public void Add(StaffMember staffMember)
        {
            _context.StaffMembers.Add(staffMember);
        }

        public void Delete(int id)
        {
            var employee = GetById(id);
            _context.StaffMembers.Remove(employee);
        }

        public List<StaffMember> GetAll()
        {
            return _context.StaffMembers.FromSqlRaw("EXEC sp_getEmployees").ToList();
        }

        public StaffMember GetById(int id)
        {
            return _context.StaffMembers.Find(id);
        }

        public void Edit(StaffMember staffMember)
        {
            _context.StaffMembers.Update(staffMember);
        }
    }
}
