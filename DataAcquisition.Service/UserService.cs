using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Interfaces.UnitOfWorks;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Service
{
    /// <summary>
    /// Communicate with the API
    /// </summary>
    public class UserService : Service<User>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork, IRepository<User> repository) : base(unitOfWork, repository)
        {
        }

        /// <summary>
        /// Returns a user entity with its company
        /// </summary>
        /// <param name="email"></param>
        public async Task<User> GetUserWithCompanyAsync(string email)
        {
            return await UnitOfWork.User.GetUserWithCompanyAsync(email);
        }

        /// <summary>
        /// Returns a user entity with its all experiments
        /// </summary>
        /// <param name="email"></param>
        public async Task<User> GetUserWithExperimentsAsync(string email)
        {
            return await UnitOfWork.User.GetUserWithExperimentsAsync(email);
        }
    }
}
