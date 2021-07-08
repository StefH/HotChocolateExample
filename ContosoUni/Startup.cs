using System;
using AutoMapper;
using HotChocolate;
using HotChocolate.Execution.Options;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ContosoUniversity
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SchoolContext>();

            services.AddAutoMapper(typeof(Startup));

            services.AddHttpContextAccessor();

            // services.AddLogging();

            services.AddGraphQLServer()

                    .AddQueryType<Query>()

                    // Add filtering and sorting capabilities.
                    .AddFiltering()
                    .AddSorting()

                    // https://chillicream.com/docs/hotchocolate/fetching-data/projections
                    .AddProjections()

                    // if you wanted to controll the pagination settings globally you could
                    // do so by setting the paging options.
                    // .SetPagingOptions()

                    // Since we are exposing a subscription type we also need a pub/sub system 
                    // handling the subscription events. For our little demo here we will use 
                    // an in-memory pub/sub system.
                    .AddInMemorySubscriptions()

                    // Last we will add apollo tracing to our server which by default is 
                    // only activated through the X-APOLLO-TRACING:1 header.
                    .AddApolloTracing(TracingPreference.Always)
                    ;

            //services.AddGraphQL(
            //    SchemaBuilder.New()
            //        .AddQueryType<Query>()
            //        .Create(),
            //        new QueryExecutionOptions
            //        {
            //            ForceSerialExecution = true,
            //            IncludeExceptionDetails = true,
            //            TracingPreference = TracingPreference.Always
            //        }).AddErrorFilter(error =>
            //        {
            //            Console.WriteLine(error.Exception);
            //            return error;
            //        });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            InitializeDatabase(app);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app
                .UseRouting()
                .UseEndpoints(endpoint => endpoint.MapGraphQL("/uni"));
        }

        private static void InitializeDatabase(IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();

            var context = serviceScope.ServiceProvider.GetRequiredService<SchoolContext>();

            if (context.Database.EnsureCreated())
            {
                var course = new Course { Credits = 10, Title = "Object Oriented Programming 1" };
                context.Courses.Add(course);
                context.SaveChangesAsync();

                var e1 = new Enrollment
                {
                    Course = course,
                };
                var e2 = new Enrollment
                {
                    Course = course,
                };
                var e3 = new Enrollment
                {
                    Course = course,
                };
                context.Enrollments.Add(e1);
                context.Enrollments.Add(e2);
                context.Enrollments.Add(e3);
                context.SaveChangesAsync();

                var s1 = new Student { FirstMidName = "Rafael", LastName = "Foo", EnrollmentDate = DateTime.UtcNow };
                var s2 = new Student { FirstMidName = "Pascal", LastName = "Bar", EnrollmentDate = DateTime.UtcNow };
                var s3 = new Student { FirstMidName = "Michael", LastName = "Baz", EnrollmentDate = DateTime.UtcNow };
                context.Students.Add(s1);
                context.Students.Add(s2);
                context.Students.Add(s3);
                context.SaveChangesAsync();

                s1.Enrollments.Add(e1);
                s2.Enrollments.Add(e2);
                s3.Enrollments.Add(e3);
                context.SaveChangesAsync();
            }
        }
    }
}