using System;

namespace ContosoUniversity.Models
{
    public class StudentModel
    { public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}