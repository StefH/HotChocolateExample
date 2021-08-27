using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using HotChocolate.Data.Filters;
using HotChocolate.Data.Filters.Expressions;
using HotChocolate.Language;
using HotChocolate.Types;
using StarWars.Utils;

namespace StarWars.Filters
{
    public class QueryableStringEqualsInvariantCultureIgnoreCaseEqualsHandler : QueryableStringOperationHandler
    {
        // public bool Equals(string value, StringComparison comparisonType)
        private static readonly MethodInfo _equals = MethodFinder.GetPublicMethodsBySignature(
            typeof(string),
            nameof(string.Equals),
            typeof(bool),
            null,
            false,
            typeof(string), typeof(StringComparison)).Single();

        public QueryableStringEqualsInvariantCultureIgnoreCaseEqualsHandler(InputParser inputParser) : base(inputParser)
        {
        }

        protected override int Operation => CustomFilteringOperation.EqualsIgnoreCase;

        public override Expression HandleOperation(
            QueryableFilterContext context,
            IFilterOperationField field,
            IValueNode value,
            object? parsedValue)
        {
            Expression property = context.GetInstance();
            if (parsedValue is string str)
            {
                return Expression.Call(property, _equals, Expression.Constant(str), Expression.Constant(StringComparison.InvariantCultureIgnoreCase));
            }

            throw new InvalidOperationException();
        }
    }
}