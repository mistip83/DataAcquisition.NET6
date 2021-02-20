using System.Threading.Tasks;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Services
{
    public interface IUserService :IService<User>
    {
        /// <summary>
        /// Returns a user entity with its company
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<User> GetUserWithCompanyAsync(string email);

        /// <summary>
        /// Returns a user entity with its all experiments
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<User> GetUserWithExperimentsAsync(string email);
    }
}