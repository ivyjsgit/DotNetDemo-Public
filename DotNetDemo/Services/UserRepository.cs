using DotNetDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetDemo.Services
{
    public class UserRepository : IUserRepository
    {
        private List<UserDto> _userContext;
        public UserRepository() {
            _userContext = new List<UserDto>() {
                 new UserDto(){
                     id = new Guid(),
                     firstName = "Mark",
                     lastName  = "Otto",
                     age = 30,
                 },
                 new UserDto(){
                     id = new Guid(),
                     firstName = "Lary",
                     lastName  = "Page",
                     age = 35,
                 },
                 new UserDto(){
                     id = new Guid(),
                     firstName = "Eric",
                     lastName  = "Jones",
                     age = 40,
                 },
            };
        }

        public void addUser(UserDto user)
        {
            user.id = new Guid();
            _userContext.Add(user);
        }

        public IEnumerable<UserDto> allUsers()
        {
            return _userContext.ToList();
        }

        public UserDto deleteUser(Guid id)
        {
            UserDto toRemove = _userContext.FirstOrDefault(u => u.id == id);
            _userContext.Remove(toRemove);
            return toRemove;
        }

        public void updateUser(UserDto user)
        {
            throw new NotImplementedException();
        }
    }
}
