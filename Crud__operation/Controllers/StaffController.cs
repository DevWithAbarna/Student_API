using Crud__operation.Db;
using Crud__operation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crud__operation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        
        public StaffController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpPost]
        [Route("Create")]
        public IActionResult create([FromBody]Staff s1)
        {
            _db.Add(s1);
            _db.SaveChanges();
            return Ok(s1);
        }
        [HttpGet]
        [Route("GetAllStaff")]
        public IActionResult GetAll()
        {
            List<Staff> Staff = new List<Staff>();
            Staff = _db.Staffs.ToList();
            return Ok(Staff);
        }
        [HttpGet]
        [Route("GetByID")]
        public IActionResult GetById(int id)
        {
            Staff s1 = _db.Staffs.FirstOrDefault(x => x.Id == id);
            return Ok(s1);
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromBody] Staff s1)
        {
            _db.Update(s1);
            _db.SaveChanges();
            return Ok(s1);
        }
        [HttpDelete]
        [Route("Delete")]
        public IActionResult DeleteById(int id)
        {
            Staff s1 = _db.Staffs.FirstOrDefault(x => x.Id == id);
            _db.Remove(s1);
            _db.SaveChanges();
            return Ok(s1);
        }
    }
}

        
