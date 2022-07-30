using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tech.Core.Concrete;
using Tech.Core.DTOs;
using Tech.Core.Services;

namespace Tech.API.Controllers
{
 
    public class PostController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Post> _service;
        

        public PostController(IService<Post> service, IMapper mapper)
        {

            _mapper = mapper;
            _service = service;
            
        }

       



        [HttpGet]
       public async Task<IActionResult> All()
        {
            var posts = await _service.GetAllAsync();

            var postsDtos = _mapper.Map<List<PostDto>>(posts).ToList();

            return CreateActionResult(CustomResponseDto<List<PostDto>>.Success(200, postsDtos));
        }

        [HttpPost]
        public async Task<IActionResult> Save(PostDto postDto)
        {
            var post = await _service.AddAsync(_mapper.Map<Post>(postDto));

            var postsDto = _mapper.Map<PostDto>(post);
            return CreateActionResult(CustomResponseDto<PostDto>.Success(201, postsDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var post = await _service.GetByIdAsync(id);

            var postsDtos = _mapper.Map<PostDto>(post);
            return CreateActionResult(CustomResponseDto<PostDto>.Success(200, postsDtos));
        }

       

        [HttpPut]
        public async Task<IActionResult> Update(PostUpdateDto postUpdateDto)
        {
            await _service.UpdateAsync(_mapper.Map<Post>(postUpdateDto));

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        // Delete api/products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var post = await _service.GetByIdAsync(id);

            await _service.RemoveAsync(post);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
