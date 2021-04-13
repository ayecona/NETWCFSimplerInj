using System.Runtime.Serialization;

namespace knchrazo.Application.Dtos
{
    [DataContract]
    public class UspGetEmployeeManagersDTO
    {
        [DataMember]
        public int RecursionLevel { get; set; }

        [DataMember]
        public int BusinessEntityID { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string OrganizationNode { get; set; }

        [DataMember]
        public string ManagerFirstName { get; set; }

        [DataMember]
        public string ManagerLastName { get; set; }

    }
}
