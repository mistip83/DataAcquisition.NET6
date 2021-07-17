using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAcquisition.Model.Entities;

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

        /// <summary>
        /// Returns facility entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<Facility> GetFacilityInfoAsync(Guid id);

        /// <summary>
        /// Returns facility list
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Facility>> GetFacilityList();

        /// <summary>
        /// Edit facility
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Facility EditFacility(Facility facility);
    }
}