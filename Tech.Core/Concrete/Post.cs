using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Core.Concrete
{
    public class Post:BaseEntity
    {

        public int PostId { get; set; }

        public string? Title { get; set; }

        public string? Body { get; set; }

        public int UserId { get; set; }

        public User? User { get; set; }

    }
}
