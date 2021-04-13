using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace knchrazo.Domain.Entities
{
    [Table("Person")]
    public class Person
    {
        [Key]
        /// <summary>
        /// Primary key for Person records.
        /// </summary>
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        /// <summary>
        /// Primary type of person: SC = Store Contact, IN = Individual (retail) customer, SP = Sales person, EM = Employee (non-sales), VC = Vendor contact, GC = General contact
        /// </summary>
        public string PersonType { get; set; } // PersonType (length: 2)

        /// <summary>
        /// 0 = The data in FirstName and LastName are stored in western style (first name, last name) order.  1 = Eastern style (last name, first name) order.
        /// </summary>
        public bool NameStyle { get; set; } // NameStyle

        /// <summary>
        /// A courtesy title. For example, Mr. or Ms.
        /// </summary>
        public string Title { get; set; } // Title (length: 8)

        /// <summary>
        /// First name of the person.
        /// </summary>
        public string FirstName { get; set; } // FirstName (length: 50)

        /// <summary>
        /// Middle name or middle initial of the person.
        /// </summary>
        public string MiddleName { get; set; } // MiddleName (length: 50)

        /// <summary>
        /// Last name of the person.
        /// </summary>
        public string LastName { get; set; } // LastName (length: 50)

        /// <summary>
        /// Surname suffix. For example, Sr. or Jr.
        /// </summary>
        public string Suffix { get; set; } // Suffix (length: 10)

        /// <summary>
        /// 0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners.
        /// </summary>
        public int EmailPromotion { get; set; } // EmailPromotion

        /// <summary>
        /// Additional contact information about the person stored in xml format.
        /// </summary>
        public string AdditionalContactInfo { get; set; } // AdditionalContactInfo

        /// <summary>
        /// Personal information such as hobbies, and income collected from online shoppers. Used for sales analysis.
        /// </summary>
        public string Demographics { get; set; } // Demographics

        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; } // rowguid

        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) Person_Person pointed by [Employee].[BusinessEntityID] (FK_Employee_Person_BusinessEntityID)
        /// </summary>
        public virtual Employee HumanResources_Employee { get; set; } // Employee.FK_Employee_Person_BusinessEntityID

        public Person()
        {
            NameStyle = false;
            EmailPromotion = 0;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }
    }
}
