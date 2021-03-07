using System.Threading.Tasks;
using DataAcquisition.Interface.Models.Entities;

namespace DataAcquisition.Interface.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// Returns a user entity with its all experiments
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<User> GetUserWithExperimentsAsync(string email);

        /// <summary>
        /// Returns a user entity with its company
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<User> GetUserWithCompanyAsync(string email);
    }
}