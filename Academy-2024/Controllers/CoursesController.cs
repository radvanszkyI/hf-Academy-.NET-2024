using Academy_2024.Models;
using Academy_2024.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Academy_2024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;

        public CoursesController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        // GET: api/<CoursesController>
        /*[HttpGet]
        public async Task<IEnumerable<Course>> Get()
        {
            return await _courseRepository.GetAllAsync();
        }

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public ActionResult<Course> Get(int id)
        {
            var course = _courseRepository.GetById(id);
            return course == null ? NotFound() : course;
        }

        // POST api/<CoursesController>
        [HttpPost]
        public ActionResult Post([FromBody] Course data)
        {
            _courseRepository.Create(data);
            return NoContent();
        }

        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Course data)
        {
            var course = _courseRepository.Update(id, data);
            return course == null ? NotFound() : NoContent();
        }

        // DELETE api/<CoursesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return _courseRepository.Delete(id) ? NoContent() : NotFound();
        }*/
    }
}
