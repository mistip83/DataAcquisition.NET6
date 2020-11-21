using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Istip.DataAcquisition.Core.EntityModels;

namespace Istip.DataAcquisition.Core.Repositories
{
    public interface IOrganizationRepository : IRepository<Organization>
    {
        Task<Organization> GetOrganizationWithFacilitiesByOrganizationIdAsync(int id);
    }
}
