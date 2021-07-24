using System.Threading.Tasks;
using DataAcquisition.Interface.Repositories;
using DataAcquisition.Interface.Services;
using DataAcquisition.Interface.UnitOfWorks;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.Service.DatabaseServices
{
    public class FacilityService : Service<Facility>, IFacilityService
    {
        public FacilityService(IUnitOfWork unitOfWork, IRepository<Facility> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Facility> GetFacilityWithWorkStationsAsync(int id)
        {
            return await UnitOfWork.Facilities.GetFacilityWithWorkStationsAsync(id);
        }
    }
}