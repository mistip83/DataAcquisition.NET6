using System;
using System.Threading.Tasks;
using DataAcquisition.Interface.Models.Entities;

namespace DataAcquisition.Interface.Services
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