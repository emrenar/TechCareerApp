using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tech.Core.Concrete;
using Tech.Core.DTOs;

namespace Tech.Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Post,PostDto>().ReverseMap();
            CreateMap<PostUpdateDto, Post>();
           
        }
    }
}
