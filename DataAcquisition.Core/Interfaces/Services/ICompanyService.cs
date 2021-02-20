using System;
using System.Threading.Tasks;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Services
{
    public interface ICompanyService
    {
        /// <summary>
        /// Returns company entity with its facilities
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<Company> GetCompanyWithFacilitiesAsync(Guid id);
    }
}
