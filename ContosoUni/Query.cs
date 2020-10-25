using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using ContosoUniversity.Models;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity
{
    public class Query
    {
        private readonly IMapper _mapper;
        private readonly SchoolContext _schoolContext;

        public Query(IMapper mapper, SchoolContext schoolContext)
        {
            _mapper = mapper;
            _schoolContext = schoolContext;
        }

        //[UseFirstOrDefault]
        //[UseSelection]
        //public IQueryable<Student> GetStudentById([Service]SchoolContext context, int studentId) =>
        //    context.Students.Where(t => t.Id == studentId);

        [UseFirstOrDefault]
        [UseSelection]
        public IEnumerable<StudentModel> GetStudentById(int studentId)
        {
            return _mapper.ProjectTo<StudentModel>(_schoolContext.Students.Where(t => t.Id == studentId)).ToList();
        }

        [UseFirstOrDefault]
        [UseSelection]
        public IQueryable<StudentModel> GetStudentByIdError(int studentId)
        {
            return _mapper.ProjectTo<StudentModel>(_schoolContext.Students.Where(t => t.Id == studentId));
        }

        [UseSelection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<StudentModel> GetStudents([Service]SchoolContext context) =>
            _mapper.ProjectTo<StudentModel>(context.Students.AsNoTracking());

        //[UsePaging]
        //[UseSelection]
        //[UseFiltering]
        //[UseSorting]
        //public IQueryable<Course> GetCourses([Service]SchoolContext context) =>
        //    context.Courses;
    }
}