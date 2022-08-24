using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Data;

namespace WebApi.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        ApplicationDbContext _context;

        public SchoolController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Create
        [HttpPost]
        public Result AddResult([FromBody] Result result)
        {
            _context.Results.Add(result);
            _context.SaveChanges();

            return result;
        }

        // Read
        [HttpGet]
        public List<Result> GetResults()
        {
            List<Result> results = _context.Results
                .OrderByDescending(item => item.Date)
                .ToList();

            return results;
        }

        [HttpGet("{id}")]
        public Result GetResults(int id)
        {
            Result result = _context.Results
                 .Where(item => item.Id == id)
                 .FirstOrDefault();

            return result;
        }

        // Update
        [HttpPut]
        public bool UpdateResult([FromBody] Result result)
        {
            var findResult = _context.Results
                .Where(x => x.Id == result.Id)
                .FirstOrDefault();

            if (findResult == null)
                return false;

            findResult.UserName = result.UserName;
            findResult.prompt = result.prompt;
            _context.SaveChanges();

            return true;
        }

        // Delete
        [HttpDelete("{id}")]
        public bool DeleteResult(int id)
        {
            var findResult = _context.Results
                .Where(x => x.Id == id)
                .FirstOrDefault();

            if (findResult == null)
                return false;

            _context.Results.Remove(findResult);
            _context.SaveChanges();

            return true;
        }
    }
}
