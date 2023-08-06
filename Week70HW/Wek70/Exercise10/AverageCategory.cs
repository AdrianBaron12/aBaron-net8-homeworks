namespace Wek70.Exercise10
{
    public static class AverageCategory
    {
        public static void Run()
        {
            AveragePriceCategory();
        }

        private static void AveragePriceCategory()
        {
            var products = new List<Product>
            {
                new Product { Name = "Product 1", Category = "Category 1", Price = 10 },
                new Product { Name = "Product 2", Category = "Category 2", Price = 20 },
                new Product { Name = "Product 3", Category = "Category 1", Price = 15 },
                new Product { Name = "Product 4", Category = "Category 3", Price = 5 },
                new Product { Name = "Product 5", Category = "Category 3", Price = 5 }
            };

            List<string> distinctCategory = products.Select(x => x.Category)
                                              .Distinct()
                                              .OrderBy(x => x)
                                              .ToList();

            Console.WriteLine("Distinct categories sorted by name in alphabetical order:");
            foreach (string category in distinctCategory)
            {
                Console.WriteLine(category);
            }
        }

    }
}
