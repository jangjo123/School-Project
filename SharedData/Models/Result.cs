using System;
using System.Collections.Generic;
using System.Text;

namespace SharedData.Models
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
