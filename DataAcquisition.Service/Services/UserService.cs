using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Interfaces.UnitOfWorks;
using DataAcquisition.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAcquisition.Service.Services
{
    class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<User> AddAsync(User user)
        {
            await _unitOfWork.Users.AddAsync(user);
            await _unitOfWork.CommitAsync();

            return user;
        }

        public async Task<IEnumerable<User>> AddRangeAsync(IEnumerable<User> users)
        {
            await _unitOfWork.Users.AddRangeAsync(users);
            await _unitOfWork.CommitAsync();

            return users;
        }

        public async Task<IEnumerable<User>> WhereAsync(Expression<Func<User, bool>> predicate)
        {
            return await _unitOfWork.Users.WhereAsync(predicate);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _unitOfWork.Users.GetAllAsync();
        }

        public async Task<User> GetByIdAsync(User user)
        {
            return await _unitOfWork.Users.SingleOrDefaultAsync(u => u.Email == user.Email);
        }

        public void Remove(User user)
        {
            _unitOfWork.Users.Remove(user);

            _unitOfWork.Commit();
        }

        public void RemoveRange(IEnumerable<User> users)
        {
            _unitOfWork.Users.RemoveRange(users);

            _unitOfWork.Commit();
        }

        public async Task<User> SingleOrDefaultAsync(Expression<Func<User, bool>> predicate)
        {
            return await _unitOfWork.Users.SingleOrDefaultAsync(predicate);
        }

        public User Update(User user)
        {
            var updatedUser = _unitOfWork.Users.Update(user);

            _unitOfWork.Commit();

            return updatedUser;
        }
    }
}
