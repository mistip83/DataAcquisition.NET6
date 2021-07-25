using System.Threading.Tasks;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.Interface.Services
{
    public interface IWorkstationService : IService<Workstation>
    {
        /// <summary>
        /// Returns workstation entity with its experiments
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<Workstation> GetWorkstationWithDevicesAndExperimentsAsync(int id);
    }
}