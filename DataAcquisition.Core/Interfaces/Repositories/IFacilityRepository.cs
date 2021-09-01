﻿using System.Threading.Tasks;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Repositories
{
    public interface IFacilityRepository : IRepository<Facility>
    {
        /// <summary>
        /// Returns facility entity with its workstations
        /// </summary>
        /// <param name="id"></param>
        Task<Facility> GetFacilityWithWorkStationsAsync(int id);
    }
}