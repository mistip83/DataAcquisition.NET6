using System;
using System.Threading.Tasks;
using DataAcquisition.Interface.Models.Entities;

namespace DataAcquisition.Interface.Services
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
