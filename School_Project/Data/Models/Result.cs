using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Project.Data.Models
{
    public class Result
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string prompt { get; set; }
        public DateTime Date { get; set; }
        
    }
}
