using knchrazo.Domain;
using knchrazo.Domain.Entities;
using knchrazo.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knchrazo.Infrastructure
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {


        static ApplicationDbContext()
        {
            Database.SetInitializer<ApplicationDbContext>(null);
        }
        public ApplicationDbContext() : base("DefaultConnection")
        {
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;  // the default value should be True as we do not want to load all the related Entities
        }

        public DbSet<Employee> Employees { get; set; } // Employee
        public DbSet<Person> People { get; set; } // Person








        // Stored Procedures
        public async Task<List<UspGetEmployeeManagers>> UspGetEmployeeManagersAsync(int businessEntityID)
        {
            var businessEntityIDParam = new SqlParameter { ParameterName = "@BusinessEntityID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = businessEntityID };
            if (businessEntityIDParam.Value == null)
                businessEntityIDParam.Value = DBNull.Value;

            List<UspGetEmployeeManagers> procResultData;

            procResultData = await Database.SqlQuery<UspGetEmployeeManagers>("EXEC [dbo].[uspGetEmployeeManagers] @BusinessEntityID", businessEntityIDParam).ToListAsync();
       
            return procResultData;
        }

        

    }

}
