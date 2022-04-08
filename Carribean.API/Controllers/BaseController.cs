
using Carribean.API.Models;
using Carribean.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carribean.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class BaseController<TEntity> : ControllerBase where TEntity : BaseModel 
    {
        private readonly IBaseService<TEntity> _baseService;
        public BaseController(IBaseService<TEntity> baseService)
        {
            _baseService = baseService;
        }

        [HttpGet]
        public virtual IActionResult Get()
        {
            var entities = _baseService.GetAll();
            return Ok(entities);
        }

        [HttpGet("Query")]
        public virtual IActionResult Query()
        {
            var queryResult = _baseService.Query();
            return Ok(queryResult);
        }

        [HttpGet("{id}")]
        public virtual IActionResult GetById(int id)
        {
            var entityById = _baseService.GetById(id);

            var isEntityNull = entityById == null;

            if (isEntityNull)
                return NoContent();

            return Ok(entityById);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Create([FromBody] TEntity entity)
        {
            var entityResult = await _baseService.Create(entity);
            return Ok(entityResult);
        }
        [HttpPut]
        public virtual async Task<IActionResult> Update([FromBody] TEntity entity)
        {
            var entityResult = await _baseService.Update(entity);
            return Ok(entityResult);
        }
        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            await _baseService.Delete(id);
            return NoContent();
        }
    }
}
