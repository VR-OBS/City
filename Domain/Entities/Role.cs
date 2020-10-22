using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace City.Domain.Entities
{
    public class Role:EntityBase
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
