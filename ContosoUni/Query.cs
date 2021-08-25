using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ContosoUniversity.Models;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ContosoUniversity
{
    public class Query
    {
        private readonly IMapper _mapper;
        //private readonly SchoolContext _schoolContext;
        private readonly ILogger _logger;

        public Query(IMapper mapper, ILogger<Query> logger)
        {
            _mapper = mapper;
            _logger = logger;
        }

        //[UseFirstOrDefault]
        //[UseSelection]
        //public IQueryable<Student> GetStudentById([Service]SchoolContext context, int studentId) =>
        //    context.Students.Where(t => t.Id == studentId);

        [UseDbContext(typeof(SchoolContext))]
        [UseFirstOrDefault]
        [UseProjection]
        [UseFiltering]
        public IEnumerable<StudentModel> GetStudentById([Service] SchoolContext context, int studentId)
        {
            return _mapper.ProjectTo<StudentModel>(context.Students.Include(s => s.Enrollments)).Where(s => s.Id == studentId).ToList();
        }


        // The middleware pipeline order for the field `Query.students` is invalid.
        // Middleware order is important especially with data pipelines.
        // The correct order of a data pipeline is as follows: UseDbContext -> UsePaging -> UseProjection -> UseFiltering -> UseSorting. You may omit any of these middleware or have other middleware in between but you need to abide by the overall order.
        // Your order is: UseFiltering -> UseSorting -> UseProjection. (HotChocolate.Types.ObjectType<ContosoUniversity.Query>)

[UseDbContext(typeof(SchoolContext))]
[UseProjection]
[UseFiltering]
[UseSorting]
public IQueryable<Student> GetStudents([ScopedService] SchoolContext dbContext)
{
    return dbContext.Students.Include(s => s.Enrollments).AsNoTracking();
}
    }
}