using knchrazo.Application.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace knchrazo.Application.Repository.IRepository
{
    public interface IEmployeeManagerRepository
    {
        Task<List<UspGetEmployeeManagersDTO>> UspGetEmployeeManagers(int businessEntityID);
    }
}
