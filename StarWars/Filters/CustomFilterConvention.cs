using HotChocolate.Data;
using HotChocolate.Data.Filters;
using HotChocolate.Data.Filters.Expressions;
using HotChocolate.Types;

namespace StarWars.Filters
{
    /// <summary>
    /// - https://github.com/PascalSenn/Filtering.Demo
    /// - https://chillicream.com/docs/hotchocolate/api-reference/extending-filtering#extending-iqueryable
    /// </summary>
    public class CustomFilterConvention : FilterConvention
    {
        protected override void Configure(IFilterConventionDescriptor descriptor)
        {
            descriptor.AddDefaults();

            // Operation is required:
            // `Operation with identifier 1026 has no name defined. Add a name to the filter convention (HotChocolate.Data.Filters.StringOperationFilterInputType)`
            descriptor.Operation(CustomFilteringOperation.ContainsIgnoreCase).Name("containsIgnoreCase").Description("string.Contains with InvariantCultureIgnoreCase");
            descriptor.Operation(CustomFilteringOperation.EqualsIgnoreCase).Name("equalsIgnoreCase").Description("string.Equals with InvariantCultureIgnoreCase");

            
            descriptor.Configure<StringOperationFilterInputType>(filterInputTypeDescriptor =>
            {
                // Type<StringType> is required:
                // `For the operation containsIgnoreCase of type StringOperationFilterInput was no type specified found.`

                /*
                 * Generates:
                 * 
                 * """
                 * string.Contains with InvariantCultureIgnoreCase
                 * """
                 * containsIgnoreCase: String
                 */
                filterInputTypeDescriptor.Operation(CustomFilteringOperation.ContainsIgnoreCase).Type<StringType>();

                /*
                 * Generates:
                 * 
                 * """
                 * string.Equals with InvariantCultureIgnoreCase
                 * """
                 * equalsIgnoreCase: String
                 */
                filterInputTypeDescriptor.Operation(CustomFilteringOperation.EqualsIgnoreCase).Type<StringType>();
            });

            descriptor.Provider(new QueryableFilterProvider(
                configure => configure
                    .AddDefaultFieldHandlers()
                    .AddFieldHandler<QueryableStringContainsInvariantCultureIgnoreCaseHandler>()
                    .AddFieldHandler<QueryableStringEqualsInvariantCultureIgnoreCaseEqualsHandler>()
                )
            );
        }
    }
}