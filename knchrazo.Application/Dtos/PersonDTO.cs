using knchrazo.Domain.Entities;
using System;
using System.Runtime.Serialization;

namespace knchrazo.Application.Dtos
{
    [DataContract]
    public class PersonDTO
    {

        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        [DataMember]
        public string PersonType { get; set; } // PersonType (length: 2)

        [DataMember]
        public bool NameStyle { get; set; } // NameStyle

        [DataMember]
        public string Title { get; set; } // Title (length: 8)

        [DataMember]
        public string FirstName { get; set; } // FirstName (length: 50)

        [DataMember]
        public string MiddleName { get; set; } // MiddleName (length: 50)

        [DataMember]
        public string LastName { get; set; } // LastName (length: 50)

        [DataMember]
        public string Suffix { get; set; } // Suffix (length: 10)

        [DataMember]
        public int EmailPromotion { get; set; } // EmailPromotion

        [DataMember]
        public string AdditionalContactInfo { get; set; } // AdditionalContactInfo

        [DataMember]
        public string Demographics { get; set; } // Demographics

        [DataMember]
        public Guid Rowguid { get; set; } // rowguid

        [DataMember]
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        [DataMember]
        public virtual Employee HumanResources_Employee { get; set; } // Employee.FK_Employee_Person_BusinessEntityID
    }
}
