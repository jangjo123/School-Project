﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShareData.Models
{
    public class GameResult
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Score { get; set; }
        public DateTime DateTime { get; set; }
    }
}
