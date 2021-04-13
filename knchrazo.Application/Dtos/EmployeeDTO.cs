using knchrazo.Domain.Entities;
using System;
using System.Runtime.Serialization;

namespace knchrazo.Application.Dtos
{
    [DataContract]
    public class EmployeeDTO
    {

        [DataMember]
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        [DataMember]
        public string NationalIdNumber { get; set; } // NationalIDNumber (length: 15)

        [DataMember]
        public string LoginId { get; set; } // LoginID (length: 256)

        [DataMember]
        public System.Data.Entity.Hierarchy.HierarchyId OrganizationNode { get; set; } // OrganizationNode

        [DataMember]
        public short? OrganizationLevel { get; private set; } // OrganizationLevel

        [DataMember]
        public string JobTitle { get; set; } // JobTitle (length: 50)

        [DataMember]
        public DateTime BirthDate { get; set; } // BirthDate

        [DataMember]
        public string MaritalStatus { get; set; } // MaritalStatus (length: 1)

        [DataMember]
        public string Gender { get; set; } // Gender (length: 1)

        [DataMember]
        public DateTime HireDate { get; set; } // HireDate

        [DataMember]
        public bool SalariedFlag { get; set; } // SalariedFlag

        [DataMember]
        public short VacationHours { get; set; } // VacationHours

        [DataMember]
        public short SickLeaveHours { get; set; } // SickLeaveHours

        [DataMember]
        public bool CurrentFlag { get; set; } // CurrentFlag

        [DataMember]
        public Guid Rowguid { get; set; } // rowguid

        [DataMember]
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        [DataMember]
        // Foreign keys
        /// <summary>
        /// Parent Person_Person pointed by [Employee].([BusinessEntityId]) (FK_Employee_Person_BusinessEntityID)
        /// </summary>
        public virtual Person Person_Person { get; set; } // FK_Employee_Person_BusinessEntityID

    }
}
