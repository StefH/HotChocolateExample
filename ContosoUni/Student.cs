using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HotChocolate.Data;

namespace ContosoUniversity
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [UseFiltering]
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //[UseProjection]
        //[UseFiltering]
        //[UseSorting]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public List<Enrollment> Enrollments { get; } = new List<Enrollment>();
    }
}