using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Models.Entities;
using DataAcquisition.Data.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DataAcquisition.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private AppDbContext AppDbContext => Context as AppDbContext;

        public UserRepository(DbContext context) : base(context)
        {
        }

        public async Task<User> GetUserWithExperimentsAsync(string email)
        {
            return await AppDbContext.Users.Include(x => x.Experiments)
                .SingleOrDefaultAsync(x => x.Email == email);
        }
    }
}