using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace MVCBartender.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Sunrise",
                        Description = "A drink that looks like a sunrise.",
                        Price = 5.75
                    },
                    new Product
                    {
                        Name = "Sunset",
                        Description = "For the end of the day.",
                        Price = 6.5
                    },
                    new Product
                    {
                        Name = "Anytime",
                        Description = "Best tasted anytime day or night.",
                        Price = 4.25
                    },
                    new Product
                    {
                        Name = "Lunch",
                        Description = "For those very stressful days when you need a pickup to make it" +
                        " through the afternoon.",
                        Price = 3.65
                    }
                    );
                context.SaveChanges();
            }// end if
        } // end EnsurePopulated method
    } // end SeedData class
} // end MVCBartender.Models namespace
