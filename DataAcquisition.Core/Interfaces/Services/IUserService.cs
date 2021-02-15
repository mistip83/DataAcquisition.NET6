using System.Collections.Generic;
using System.Threading.Tasks;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Services
{
    public interface IUserService :IService<User>
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
    }
}