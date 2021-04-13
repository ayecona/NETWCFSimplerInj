using AutoMapper;
using knchrazo.Application.Dtos;
using knchrazo.Application.Repository.IRepository;
using knchrazo.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace knchrazo.Application.Repository
{


    public class EmployeeManagerRepository : IEmployeeManagerRepository
    {

        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public EmployeeManagerRepository(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<UspGetEmployeeManagersDTO>> UspGetEmployeeManagers(int businessEntityID)
        {
            try
            {
                var dtoList = new List<UspGetEmployeeManagersDTO>();
                var vm = await _context.UspGetEmployeeManagersAsync(businessEntityID);

                foreach (var item in vm)
                {
                    dtoList.Add(_mapper.Map<UspGetEmployeeManagersDTO>(item));
                }
                return dtoList;
            }
            catch (Exception ex)
            {
                return null;
            }


        }
    }
}
