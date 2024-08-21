using Demo3WinForm.Data;
using Demo3WinForm.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Demo3WinForm.Services
{
    public class SearchService
    {
        public List<HomeViewModel> Search(string name)
        {
            var searchText = name.Trim();

            using (var context = new DemoDbContext())
            {
                var searchResults = context.ProcessParameters
                  .Where(pp => pp.ParameterName.Contains(searchText)
                         || pp.ParameterValue.Contains(searchText)
                         || pp.Version.ToString().Contains(searchText)
                         || pp.Process.ProcessName.Contains(searchText)
                         || pp.Process.Route.RouteName.Contains(searchText)
                         || pp.Process.Route.Product.ProductName.Contains(searchText))
                .Select(pp => new HomeViewModel
                {
                    Id = pp.Id,
                    ParameterName = pp.ParameterName,
                    ParameterValue = pp.ParameterValue,
                    Version = pp.Version,
                    ProcessName = pp.Process.ProcessName,
                    RouteName = pp.Process.Route.RouteName,
                    ProductName = pp.Process.Route.Product.ProductName
                }).ToList();

                return searchResults;
            }
        }
    }
}
