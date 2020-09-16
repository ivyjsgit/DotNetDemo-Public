using DotNetDemo.Enities;
using DotNetDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetDemo.Services
{
    public class UserDBInfoRepository : IUserRepository
    {
        DBcontext _dbContext;
        public UserDBInfoRepository(DBcontext dbContext) 
        {
            _dbContext = dbContext;
        }

        public void addUser(UserDto user)
        {
            User newUser = new User() {
                firstName = user.firstName,
                lastName = user.lastName,
                age = user.age
            };
            _dbContext.Add(newUser);
            _dbContext.SaveChanges();
        }

        public IEnumerable<UserDto> allUsers()
        {
            List<UserDto> users = new List<UserDto>();
            foreach (var user in _dbContext.Users)
            {
                users.Add(new UserDto()
                {
                    id = user.id,
                    firstName = user.firstName,
                    lastName = user.lastName,
                    age = user.age,
                }) ;
            }
            return users;
        }

        public UserDto deleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public void updateUser(UserDto user)
        {
            throw new NotImplementedException();
        }
    }
}
