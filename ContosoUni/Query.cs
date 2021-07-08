using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ContosoUniversity.Models;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Resolvers;
using HotChocolate.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ContosoUniversity
{
    public class Query
    {
        private readonly IMapper _mapper;
        private readonly SchoolContext _schoolContext;
        private readonly ILogger _logger;

        public Query(IMapper mapper, SchoolContext schoolContext, ILogger<Query> logger)
        {
            _mapper = mapper;
            _schoolContext = schoolContext;
            _logger = logger;
        }

        //[UseFirstOrDefault]
        //[UseSelection]
        //public IQueryable<Student> GetStudentById([Service]SchoolContext context, int studentId) =>
        //    context.Students.Where(t => t.Id == studentId);

        [UseFirstOrDefault]
        [UseProjection]
        [UseFiltering]
        public IEnumerable<StudentModel> GetStudentById([Service] SchoolContext context, int studentId)
        {
            return _mapper.ProjectTo<StudentModel>(context.Students.Where(t => t.Id == studentId)).ToList();
        }

        // [UsePaging]
        [UseFiltering]
        [UseSorting]
        [UseProjection]
        public IQueryable<StudentModel> GetStudents(
            [Service] SchoolContext dbContext,
            [Service] IResolverContext context,
            [Service] IHttpContextAccessor httpContext) //, [Service] 
        {
            //var fields = context.Field.CollectFields((ObjectType<ICollection<EnrollmentModel>>)context.Field.Type, context.FieldSelection.SelectionSet);

            // var a = context.ArgumentValue<ICollection<EnrollmentModel>>("enrollments");

            var query = context.Selection.SyntaxNode.Arguments.Any(n => n.Name.Value == nameof(StudentModel.Enrollments));
            return _mapper.ProjectTo<StudentModel>(dbContext.Students.Include(s => s.Enrollments).AsNoTracking());
        }
            

        //[UsePaging]
        //[UseSelection]
        //[UseFiltering]
        //[UseSorting]
        //public IQueryable<Course> GetCourses([Service]SchoolContext context) =>
        //    context.Courses;
    }
}