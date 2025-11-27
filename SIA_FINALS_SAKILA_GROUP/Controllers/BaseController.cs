using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIA_FINALS_SAKILA_GROUP.Models.Repositories;

namespace SIA_FINALS_SAKILA_GROUP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity, TReadDTO, TCreateDTO, TUpdateDTO> : ControllerBase where TEntity: class
    {
        protected readonly IRepository<TEntity> _repo;
        protected readonly IMapper _mapper;

        public BaseController(IRepository<TEntity> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<TReadDTO>>> GetAll()
        {
            var items = await _repo.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<TReadDTO>>(items));
        }

        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TReadDTO>> Get(int id)
        {
           var item = await _repo.GetByIdAsync(id);           
           if (item == null)
           {
                    return NotFound();
           }
           return Ok(_mapper.Map<TReadDTO>(item));           
        }

        [HttpPost]
        public virtual async Task<ActionResult<TReadDTO>> Create(TCreateDTO dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            var created = await _repo.CreateAsync(entity);
            return CreatedAtAction(nameof(Get), new { id = _mapper.Map<TReadDTO>(created) }, _mapper.Map<TReadDTO>(created));
        }

        [HttpPut("{id}")]
        public virtual async Task<ActionResult<TReadDTO>> Update(int id, TUpdateDTO dto)
        {
            var existing = await _repo.GetByIdAsync(id);
            if (existing == null) return NotFound();

            _mapper.Map(dto, existing);
            var updated = await _repo.UpdateAsync(existing);
            return Ok(_mapper.Map<TReadDTO>(updated));
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            var deleted = await _repo.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
