using Domain.Contracts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Persistance.Data.DataSeeding
{
    public class DbInitailizer : IDbIntializer
    {
        private readonly AppDbContext _dbContext;

        public DbInitailizer(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task InitalizeAsync()
        {
            try
            {
                if (_dbContext.Database.GetPendingMigrations().Any())
                {
                    await _dbContext.Database.MigrateAsync();
                    if(!_dbContext.ProductTypes.Any())
                    {
                        // C:\Users\youkhalil\source\repos\RouteCourse\E-Commerce\Infrastructure\Persistance\Data\DataSeeding\types.json
                        var typesData = await File.ReadAllTextAsync(@"..\Infrastructure\Persistance\Data\DataSeeding\types.json");
                        var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);
                        if (types != null && types.Any())
                        {
                            await _dbContext.AddRangeAsync(types);
                            await _dbContext.SaveChangesAsync();
                        }
                    }
                    if (!_dbContext.ProductBrands.Any())
                    {
                        // C:\Users\youkhalil\source\repos\RouteCourse\E-Commerce\Infrastructure\Persistance\Data\DataSeeding\brands.json
                        var brandsData = await File.ReadAllTextAsync(@"..\Infrastructure\Persistance\Data\DataSeeding\brands.json");
                        var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);
                        if (brands != null && brands.Any())
                        {
                            await _dbContext.AddRangeAsync(brands);
                            await _dbContext.SaveChangesAsync();
                        }
                    }
                    if (!_dbContext.Products.Any())
                    {
                        // C:\Users\youkhalil\source\repos\RouteCourse\E-Commerce\Infrastructure\Persistance\Data\DataSeeding\products.json
                        var productsData = await File.ReadAllTextAsync(@"..\Infrastructure\Persistance\Data\DataSeeding\products.json");
                        var products = JsonSerializer.Deserialize<List<Product>>(productsData);
                        if (products != null && products.Any())
                        {
                            await _dbContext.AddRangeAsync(products);
                            await _dbContext.SaveChangesAsync();
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
