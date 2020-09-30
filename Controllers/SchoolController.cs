using LiveEFCore.Entities;
using LiveEFCore.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiveEFCore.Controllers
{
    public class SchoolController : ControllerBase
    {
        private readonly LiveEFCoreDbContext _liveEfCoreDb;

        public SchoolController(LiveEFCoreDbContext liveEFCoreDbContext)
        {
            _liveEfCoreDb = liveEFCoreDbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var school = new School("Cool school 3");
            _liveEfCoreDb.Schools.Add(school);
            _liveEfCoreDb.SaveChanges();

            return Ok(school);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var school = _liveEfCoreDb.Schools
                .Include(s => s.ContactInformation)
                .Include(s => s.Student)
                .SingleOrDefault(s => s.Id == id);

            return Ok(school);
        }

        [HttpGet("{id}/popular")]
        public IActionResult Post(int id)
        {
            var school = _liveEfCoreDb.Schools
                .Include(s=>s.ContactInformation)
                .Include(s=>s.Student)
                .SingleOrDefault( s=> s.Id == id);

            school.AddContactInformation("rua zero");
            school.AddStudent("Estudante zero");

            _liveEfCoreDb.SaveChanges();
            return Ok(school);
        }
    }
}
