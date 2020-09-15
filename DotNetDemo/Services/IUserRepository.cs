using DotNetDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetDemo.Services
{
    public interface IUserRepository
    {
        void addUser(UserDto user);
        void updateUser(UserDto user);
        UserDto deleteUser(Guid id);
        IEnumerable<UserDto> allUsers();
    }
}
