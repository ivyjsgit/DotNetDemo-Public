using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetDemo.Models
{
    public class UserViewModelToReturn
    {

        public UserDto newUser { get; set; }
        public IEnumerable<UserDto> allUsers { get; set; }
    }
}
