using Demo3WinForm.Data;
using Demo3WinForm.Models;
using System;
using System.Collections.Generic;

namespace Demo3WinForm.Services
{
    public class MockDataService
    {
        
        public string AddMockData() {

            var products = new List<Product>
            {
                new Product { ProductName = "Product1", ProductType = "A" },
                new Product { ProductName = "Product2", ProductType = "B" },
                new Product { ProductName = "Product3", ProductType = "C" },
                new Product { ProductName = "Product4", ProductType = "D" },
                new Product { ProductName = "Product5", ProductType = "E" }
            };

            var routes = new List<ProcessRoute>
            {
                new ProcessRoute { RouteName = "Route1", Product = products[0], ProductId = products[0].Id },
                new ProcessRoute { RouteName = "Route2", Product = products[1], ProductId = products[1].Id },
                new ProcessRoute { RouteName = "Route3", Product = products[2], ProductId = products[2].Id },
                new ProcessRoute { RouteName = "Route4", Product = products[3], ProductId = products[3].Id },
                new ProcessRoute { RouteName = "Route5", Product = products[4], ProductId = products[4].Id }
            };

            var processes = new List<Process>
            {
                new Process { ProcessName = "Process1", Route = routes[0] },
                new Process { ProcessName = "Process2", Route = routes[1] },
                new Process { ProcessName = "Process3", Route = routes[0] },
                new Process { ProcessName = "Process4", Route = routes[3] },
                new Process { ProcessName = "Process5", Route = routes[4] },
                new Process { ProcessName = "Process6", Route = routes[4] },
                new Process { ProcessName = "Process7", Route = routes[2] },
                new Process { ProcessName = "Process8", Route = routes[1] },
                new Process { ProcessName = "Process9", Route = routes[3] }
            };
            var processParameters = new List<ProcessParameters>
            {
                new ProcessParameters { ParameterName = "Param1", ParameterValue = "V1", Version = 1, Process = processes[0] },
                new ProcessParameters { ParameterName = "Param2", ParameterValue = "V2", Version = 1, Process = processes[1] },
                new ProcessParameters { ParameterName = "Param3", ParameterValue = "V3", Version = 1, Process = processes[2] },
                new ProcessParameters { ParameterName = "Param4", ParameterValue = "V4", Version = 1, Process = processes[3] },
                new ProcessParameters { ParameterName = "Param5", ParameterValue = "V5", Version = 1, Process = processes[4] },
                new ProcessParameters { ParameterName = "Param6", ParameterValue = "V6", Version = 1, Process = processes[5] },
                new ProcessParameters { ParameterName = "Param7", ParameterValue = "V7", Version = 1, Process = processes[6] },
                new ProcessParameters { ParameterName = "Param8", ParameterValue = "V8", Version = 1, Process = processes[7] },
                new ProcessParameters { ParameterName = "Param9", ParameterValue = "V9", Version = 1, Process = processes[8] }
            };

            try
            {
                using (var _context = new DemoDbContext())
                {
                    DeleteExistingData(_context);
                    _context.Products.AddRange(products);
                    _context.Routes.AddRange(routes);
                    _context.Processes.AddRange(processes);
                    _context.ProcessParameters.AddRange(processParameters);
                    _context.SaveChanges();
                }
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.StackTrace;
            }
            
        }

        private void DeleteExistingData(DemoDbContext context)
        {
        
            context.Database.ExecuteSqlCommand("delete from ProcessParameters");
            context.Database.ExecuteSqlCommand("delete from Processes");
            context.Database.ExecuteSqlCommand("delete from ProcessRoutes");
            context.Database.ExecuteSqlCommand("delete from Products");

        }

    }

}
