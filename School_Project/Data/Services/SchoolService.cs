using School_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Project.Data.Services
{
    public class SchoolService
    {
        ApplicationDbContext _context;

        public SchoolService(ApplicationDbContext context)
        {
            _context = context;
        }

        // CRUD

        // Create
        public Task<Result> AddResult(Result result)
        {
            _context.Result.Add(result);
            _context.SaveChanges();

            return Task.FromResult(result);
        }

        // Read
        public Task<List<Result>> GetResultsAsync()
        {
            List<Result> results = _context.Result
                                .OrderByDescending(item => item.Id)
                                .ToList();

            return Task.FromResult(results);
        }

        // Update
        public Task<bool> UpdateResult(Result result)
        {
            var findResult = _context.Result
                .Where(x => x.Id == result.Id)
                .FirstOrDefault();

            if (findResult == null)
                return Task.FromResult(false);

            findResult.UserName = result.UserName;
            findResult.prompt = result.prompt;
            _context.SaveChanges();

            return Task.FromResult(true);
        }
        // Delect
        public Task<bool> DeleteResult(Result result)
        {
            var findResult = _context.Result
                .Where(x => x.Id == result.Id)
                .FirstOrDefault();

            if (findResult == null)
                return Task.FromResult(false);

            _context.Result.Remove(result);
            _context.SaveChanges();

            return Task.FromResult(true);
        }
    }
}
