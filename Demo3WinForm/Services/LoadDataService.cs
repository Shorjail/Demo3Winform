using Demo3WinForm.Data;
using Demo3WinForm.ViewModels;
using System.Collections.Generic;
using System.Linq;


namespace Demo3WinForm.Services
{
    public class LoadDataService
    {

        public List<HomeViewModel> LoadHomeData()
        {
            using (var context = new DemoDbContext())
            {
                var processParameters = context.ProcessParameters
                    .Select(pp => new HomeViewModel
                    {
                        Id = pp.Id,
                        ParameterName = pp.ParameterName,
                        ParameterValue = pp.ParameterValue,
                        Version = pp.Version,
                        ProcessName = pp.Process.ProcessName,
                        RouteName = pp.Process.Route.RouteName,
                        ProductName = pp.Process.Route.Product.ProductName
                    })
                    .ToList();

                return processParameters;
            }
        }

        public List<ProductViewModel> LoadProductData()
        {

            using (var context = new DemoDbContext())
            {
                return context.Products.Select(p => new ProductViewModel
                {
                    Id=p.Id,
                    ProductName=p.ProductName,
                    ProductType = p.ProductType,
                    Route= p.Route.RouteName
                }).ToList();
            }
        }

        public List<ProcessViewModel> LoadProcessData()
        {
            using (var context = new DemoDbContext())
            {
                return context.Processes.Select(p => new ProcessViewModel
                {
                    Id = p.Id,
                    ProcessName = p.ProcessName,
                    RouteName = p.Route.RouteName
                }).ToList();
            }
        }
        public List<ProcessRouteViewModel> LoadProcessRouteData()
        {
            using (var context = new DemoDbContext())
            {
                return context.Routes.Select(pr => new ProcessRouteViewModel
                {
                    Id = pr.Id,
                    RouteName = pr.RouteName,
                    ProductName = pr.Product.ProductName

                }).ToList();
            }
        }
    }
}
