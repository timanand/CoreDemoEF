using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemoEF.Data
{
    public class Uow : IUow
    {

        private readonly StaffContext _context;

        // Constructor
        public Uow(StaffContext context)
        {
            _context = context;
        }

        public IStaffRepository StaffRepository => new StaffRepository(_context);


        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
