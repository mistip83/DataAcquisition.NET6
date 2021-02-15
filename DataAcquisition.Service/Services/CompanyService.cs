using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Interfaces.UnitOfWorks;
using DataAcquisition.Core.Models.Entities;
using System;
using System.Threading.Tasks;

namespace DataAcquisition.Service.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly User _user;

        public CompanyService(IUnitOfWork unitOfWork, User user)
        {
            _unitOfWork = unitOfWork;
            _user = user;
        }

        public async Task<Company> GetCompanyInfo()
        {
            return await _unitOfWork.Company.SingleOrDefaultAsync(c => c.CompanyId == _user.Company.CompanyId);
        }
    }
}