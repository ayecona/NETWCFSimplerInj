using knchrazo.Application.Repository.IRepository;
using knchrazo.Application.Services.IService;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;

namespace knchrazo.Application.Services
{
    public class EmployeeManagerService : IEmployeeManagerService
	{
		private readonly IEmployeeManagerRepository _employeeManagerRepository;

		public EmployeeManagerService(IEmployeeManagerRepository employeeManagerRepository)
		{
			_employeeManagerRepository = employeeManagerRepository;
		}

		public string UspGetEmployeeManagersData(int businessEntityID)
		{
			var result = _employeeManagerRepository.UspGetEmployeeManagers(businessEntityID);

			// Serialize the results as JSON
			DataContractJsonSerializer serializer = new DataContractJsonSerializer(result.GetType());
			MemoryStream memoryStream = new MemoryStream();
			serializer.WriteObject(memoryStream, result);

			// Return the results serialized as JSON
			string json = Encoding.Default.GetString(memoryStream.ToArray());
			return json;

		}

	}
}
