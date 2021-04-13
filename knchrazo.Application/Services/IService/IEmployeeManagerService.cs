using System.ServiceModel;
using System.ServiceModel.Web;

namespace knchrazo.Application.Services.IService
{
	[ServiceContract]
	public interface IEmployeeManagerService
	{
		[WebGet(UriTemplate = "UspGetEmployeeManagers?BusinessEntityID={businessEntityID}", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json)]
		[OperationContract]
		string UspGetEmployeeManagersData(int businessEntityID);
	}
}
  