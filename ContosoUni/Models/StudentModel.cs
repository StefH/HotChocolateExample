using System;
using System.Collections.Generic;
using HotChocolate.Types;

namespace ContosoUniversity.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //[UseSelection]
        //[UseFiltering]
        public virtual ICollection<EnrollmentModel> Enrollments { get; set; } = new List<EnrollmentModel>();
    }
}