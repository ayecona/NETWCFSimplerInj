using knchrazo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;


namespace knchrazo.Infrastructure.Interfaces
{
    public interface IApplicationDbContext : IDisposable
    {
        DbSet<Employee> Employees { get; set; } // Employee
        DbSet<Person> People { get; set; } // Person


        // Stored Procedures
        Task<List<UspGetEmployeeManagers>> UspGetEmployeeManagersAsync(int businessEntityID);
    }
}
