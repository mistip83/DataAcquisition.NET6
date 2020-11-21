using System.Threading.Tasks;
using Istip.DataAcquisition.Core.Models.Entities;

namespace Istip.DataAcquisition.Core.Interfaces.Repositories
{
    public interface IOrganizationRepository : IRepository<Organization>
    {
        Task<Organization> GetOrganizationWithFacilitiesByOrganizationIdAsync(int id);
    }
}
