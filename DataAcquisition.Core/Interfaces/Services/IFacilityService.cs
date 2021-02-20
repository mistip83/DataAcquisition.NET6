using System;
using System.Threading.Tasks;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Services
{
    public interface IFacilityService
    {
        /// <summary>
        /// Returns facility entity with its workstations
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<Facility> GetFacilityWithWorkStationsAsync(Guid id);
    }
}