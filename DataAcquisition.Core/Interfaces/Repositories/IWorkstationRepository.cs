using System.Threading.Tasks;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Repositories;

public interface IWorkstationRepository : IRepository<Workstation>
{
    /// <summary>
    /// Returns workstation entity with its experiments
    /// </summary>
    /// <param name="id"></param>
    Task<Workstation> GetWorkstationWithDevicesAndExperimentsAsync(int id);
}