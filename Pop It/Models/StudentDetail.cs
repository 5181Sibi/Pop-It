using System;
using System.Collections.Generic;

#nullable disable

namespace Pop_It.Models
{
    public partial class StudentDetail
    {
        public StudentDetail()
        {
            Grades = new HashSet<Grade>();
            Results = new HashSet<Result>();
        }

        public int StudentId { get; set; }
        public string Emailid { get; set; }
        public string RollNo { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int CategoryId { get; set; }
        public int Grade { get; set; }
        public string StudentName { get; set; }
        public DateTime Dob { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime Lastlogin { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual UserCategory Category { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
