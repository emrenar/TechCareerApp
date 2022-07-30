using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Core.DTOs
{
    public class PostDto:BaseDto
    {
        public int PostId { get; set; }

        public string? Title { get; set; }

        public string? Body { get; set; }
    }
}
