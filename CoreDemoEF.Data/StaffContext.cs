using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using CoreDemoEF.Domain;
using Microsoft.Extensions.Logging;


namespace CoreDemoEF.Data
{
    public class StaffContext: DbContext
    {

        
        // Now ASP.NET Core will be able to instantiate a StaffContext,
        // pass in the options we defined in Startup (whether we want to use SQL Server and what is the connection string)
        // then pass the resulting object into the controller.
        public StaffContext(DbContextOptions<StaffContext> options) : base(options)
        {

        }

        
        // The name specified, 'StaffMembers' will be the name of the table created in the database
        public DbSet<StaffMember> StaffMembers { get; set; }


        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {

        // }

    }
}
