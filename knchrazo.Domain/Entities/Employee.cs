using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace knchrazo.Domain.Entities
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        /// <summary>
        /// Primary key for Employee records.  Foreign key to BusinessEntity.BusinessEntityID.
        /// </summary>
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        /// <summary>
        /// Unique national identification number such as a social security number.
        /// </summary>
        public string NationalIdNumber { get; set; } // NationalIDNumber (length: 15)

        /// <summary>
        /// Network login.
        /// </summary>
        public string LoginId { get; set; } // LoginID (length: 256)

        /// <summary>
        /// Where the employee is located in corporate hierarchy.
        /// </summary>
        public System.Data.Entity.Hierarchy.HierarchyId OrganizationNode { get; set; } // OrganizationNode

        /// <summary>
        /// The depth of the employee in the corporate hierarchy.
        /// </summary>
        public short? OrganizationLevel { get; private set; } // OrganizationLevel

        /// <summary>
        /// Work title such as Buyer or Sales Representative.
        /// </summary>
        public string JobTitle { get; set; } // JobTitle (length: 50)

        /// <summary>
        /// Date of birth.
        /// </summary>
        public DateTime BirthDate { get; set; } // BirthDate

        /// <summary>
        /// M = Married, S = Single
        /// </summary>
        public string MaritalStatus { get; set; } // MaritalStatus (length: 1)

        /// <summary>
        /// M = Male, F = Female
        /// </summary>
        public string Gender { get; set; } // Gender (length: 1)

        /// <summary>
        /// Employee hired on this date.
        /// </summary>
        public DateTime HireDate { get; set; } // HireDate

        /// <summary>
        /// Job classification. 0 = Hourly, not exempt from collective bargaining. 1 = Salaried, exempt from collective bargaining.
        /// </summary>
        public bool SalariedFlag { get; set; } // SalariedFlag

        /// <summary>
        /// Number of available vacation hours.
        /// </summary>
        public short VacationHours { get; set; } // VacationHours

        /// <summary>
        /// Number of available sick leave hours.
        /// </summary>
        public short SickLeaveHours { get; set; } // SickLeaveHours

        /// <summary>
        /// 0 = Inactive, 1 = Active
        /// </summary>
        public bool CurrentFlag { get; set; } // CurrentFlag

        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; } // rowguid

        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        [Required]
        // Foreign keys

        /// <summary>
        /// Parent Person_Person pointed by [Employee].([BusinessEntityId]) (FK_Employee_Person_BusinessEntityID)
        /// </summary>
        public virtual Person Person_Person { get; set; } // FK_Employee_Person_BusinessEntityID

        public Employee()
        {
            SalariedFlag = true;
            VacationHours = 0;
            SickLeaveHours = 0;
            CurrentFlag = true;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }
    }
}
