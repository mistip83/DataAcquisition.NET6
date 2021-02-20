using System;
using System.Threading.Tasks;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Services
{
    public interface IWorkstationService
    {
        /// <summary>
        /// Returns workstation entity with its experiments
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<Workstation> GetWorkstationWithExperimentsAsync(Guid id);
    }
}