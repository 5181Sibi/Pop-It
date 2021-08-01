using System;
using System.Collections.Generic;

#nullable disable

namespace Pop_It.Models
{
    public partial class AdminLogin
    {
        public string AdminNo { get; set; }
        public string Password { get; set; }
        public int CategoryId { get; set; }

        public virtual UserCategory Category { get; set; }
    }
}
