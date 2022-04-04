using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Models.Entities;
using DataAcquisition.DataAccessEF.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace DataAcquisition.Repository.Repositories;

/// <summary>
/// Encapsulate the logic required to access data sources
/// </summary>
public class UserRepository : Repository<User>, IUserRepository
{
    private AppDbContext AppDbContext => Context;

    public UserRepository(AppDbContext context) : base(context)
    {
    }

    /// <summary>
    /// Implementation detail
    /// </summary>
    /// <param name="email"></param>
    public async Task<User> GetUserWithExperimentsAsync(string email)
    {
        return await AppDbContext.User.Include(x => x.Experiments)
            .SingleOrDefaultAsync(x => x.Email == email);
    }

    /// <summary>
    /// Implementation detail
    /// </summary>
    /// <param name="email"></param>
    public async Task<User> GetUserWithCompanyAsync(string email)
    {
        return await AppDbContext.User.Include(x => x.Company)
            .SingleOrDefaultAsync(x => x.Email == email);
    }
}