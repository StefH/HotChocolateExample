using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazorise;
using Blazorise.DataGrid;
using Microsoft.AspNetCore.Components;
using StarWarsGeneratedClient;
using Character = StarWarsGeneratedClient.IGetCharactersWithPaging_CharactersWithPagingFilteringAndSorting_Items;

namespace StarWars.BlazorApp.Pages
{
    public partial class BlazoriseDataGrid
    {
        [Inject]
        IStarWarsGeneratedClient Client { get; set; }

        private IReadOnlyList<Character> characters;
        private int total = 0;

        async Task OnReadData(DataGridReadDataEventArgs<Character> e)
        {
            var column = e.Columns.FirstOrDefault(e => e.SortDirection != SortDirection.None);
            var sorts = new List<ICharacterSortInput>();
            if (TryParseSortColumn<ICharacterSortInput>(column, out var sort))
            {
                sorts.Add(sort);
            }

            var operationResult = await Client.GetCharactersWithPaging.ExecuteAsync(e.PageSize, (e.Page - 1) * e.PageSize, sorts);

            var result = operationResult.Data.CharactersWithPagingFilteringAndSorting;
            characters = result.Items;
            total = result.TotalCount;

            // always call StateHasChanged!
            StateHasChanged();
        }

        private static bool TryParseSortColumn<T>(DataGridColumnInfo column, out T sort) where T : new()
        {
            sort = default;

            if (column is null)
            {
                return false;
            }

            var property = typeof(T).GetProperty(column.Field);
            if (property is null)
            {
                return false;
            }

            sort = new T();
            property.SetValue(sort, Parse(column.SortDirection));
            return true;
        }

        private static SortEnumType Parse(SortDirection direction)
        {
            return direction == SortDirection.Ascending ? SortEnumType.Asc : SortEnumType.Desc;
        }
    }
}
