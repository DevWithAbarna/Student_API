using Crud__operation.Db;
using Crud__operation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crud__operation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromBody]Student s1)
        {
           // s1.id = 0;
            _db.Add(s1);
            _db.SaveChanges();
            return Ok(s1);
        }
        [HttpGet]
        [Route("GetAllStudents")]
        public IActionResult GetAll()
        {
            List<Student> students = new List<Student>();
            students = _db.Students.ToList();
            return Ok(students);
        }
        [HttpGet]
        [Route("GetByID")]
        public IActionResult GetById(int id)
        {
            Student s1 = _db.Students.FirstOrDefault(x => x.id == id);
            return Ok(s1);
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromBody] Student s1)
        {
            _db.Update(s1);
            _db.SaveChanges();
            return Ok(s1);
        }
        [HttpDelete]
        [Route("Delete")]
        public IActionResult DeleteById(int id)
        {
            Student s1=_db.Students.FirstOrDefault(x=>x.id == id);
            _db.Remove(s1);
            _db.SaveChanges();
            return  Ok(s1);
        }
    }
}
