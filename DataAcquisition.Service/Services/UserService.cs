using System.Threading.Tasks;
using DataAcquisition.Interface.UnitOfWorks;
using DataAcquisition.Interface.Models.Entities;
using DataAcquisition.Interface.Repositories;
using DataAcquisition.Interface.Services;

namespace DataAcquisition.Service.Services
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
        /// <returns></returns>
        public async Task<User> GetUserWithCompanyAsync(string email)
        {
            return await UnitOfWork.Users.GetUserWithCompanyAsync(email);
        }

        /// <summary>
        /// Returns a user entity with its all experiments
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<User> GetUserWithExperimentsAsync(string email)
        {
            return await UnitOfWork.Users.GetUserWithExperimentsAsync(email);
        }
    }
}
