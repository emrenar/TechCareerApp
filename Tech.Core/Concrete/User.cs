using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Core.Concrete
{
    public class User:BaseEntity
    {

        public int Id { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? ConfirmPassword { get; set; }

        public ICollection<Post>? Posts { get; set; }
    }
}
