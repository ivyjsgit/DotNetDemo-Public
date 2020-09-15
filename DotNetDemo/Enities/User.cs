using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetDemo.Enities
{
    public class User
    {
        public Guid id { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public int age { get; set; }
    }
}
