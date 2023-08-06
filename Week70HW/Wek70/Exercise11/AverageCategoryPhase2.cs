using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Wek70.Exercise11
{
    public static class AverageCategoryPhase2
    {
        public static void Run()
        {
            AveragePriceCategoryPhase2();
        }

        private static void AveragePriceCategoryPhase2()
        {
            List<ProductPhase2> products = new List<ProductPhase2> {
            new ProductPhase2 { Name = "Product 1", Category = "Category 1", Price = 10 },
            new ProductPhase2 { Name = "Product 2", Category = "Category 2", Price = 20 },
            new ProductPhase2 { Name = "Product 3", Category = "Category 1", Price = 15 },
            new ProductPhase2 { Name = "Product 4", Category = "Category 3", Price = 5 },
            new ProductPhase2 { Name = "Product 5", Category = "Category 3", Price = 5 }
        };

            List<CategoryAveragePrice> averagePrices = products.GroupBy(p => p.Category)
                                                               .Select(g => new CategoryAveragePrice
                                                               {
                                                                   Category = g.Key,
                                                                   AveragePrice = g.Average(p => p.Price)

                                                               })
                                                               .OrderByDescending(a => a.AveragePrice)
                                                               .ToList();

            Console.WriteLine("Categories sorted by average price descending are :");
            foreach(CategoryAveragePrice category in averagePrices)
            {
                Console.WriteLine($"{category.Category} : Average Price = {category.AveragePrice}");
            }

        }

    }
}
