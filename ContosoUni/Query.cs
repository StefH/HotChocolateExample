using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using ContosoUniversity.Models;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;

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

        [UseFirstOrDefault]
        [UseSelection]
        public IQueryable<Student> GetStudentById([Service]SchoolContext context, int studentId) =>
            context.Students.Where(t => t.Id == studentId);

        [UseFirstOrDefault]
        [UseSelection]
        public IQueryable<StudentModel> GetStudentModelById(int studentId)
        {
            return _schoolContext.Students.Where(t => t.Id == studentId).ProjectTo<StudentModel>(_mapper.ConfigurationProvider);
        }
            

        [UseSelection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Student> GetStudents([Service]SchoolContext context) =>
            context.Students;

        [UsePaging]
        [UseSelection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Course> GetCourses([Service]SchoolContext context) =>
            context.Courses;
    }
}