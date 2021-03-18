using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BonFromage.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BonFromageContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BonFromageContext>>()))
            {
                // Look for any movies.
                if (context.MenuItem.Any())
                {
                    return;   // DB has been seeded
                }

                context.MenuItem.AddRange(
                    new MenuItem
                    {
                        Title = "When Harry Met Sally",
                        ShortDescription = "Sallad",
                        LongDescription = "Gurka och tomater",
                        ImageUrl = "",
                        SellingPrice = 20,
                        ProductionPrice = 10
                    },

                     new MenuItem
                     {
                         Title = "When Harry Met Sally",
                         ShortDescription = "Sallad",
                         LongDescription = "Gurka och tomater",
                         ImageUrl = "",
                         SellingPrice = 20,
                         ProductionPrice = 10
                     },

                     new MenuItem
                     {
                         Title = "When Harry Met Sally",
                         ShortDescription = "Sallad",
                         LongDescription = "Gurka och tomater",
                         ImageUrl = "",
                         SellingPrice = 20,
                         ProductionPrice = 10
                     },

                     new MenuItem
                     {
                         Title = "When Harry Met Sally",
                         ShortDescription = "Sallad",
                         LongDescription = "Gurka och tomater",
                         ImageUrl = "",
                         SellingPrice = 20,
                         ProductionPrice = 100
                     }
                );
                context.SaveChanges();
            }
        }
    }
}