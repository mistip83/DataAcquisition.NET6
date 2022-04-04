using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Services;

public interface IWorkstationService : IService<Workstation>
{
    /// <summary>
    /// Returns workstation entity with its experiments
    /// </summary>
    /// <param name="id"></param>
    public Task<Workstation> GetWorkstationWithDevicesAndExperimentsAsync(int id);
}