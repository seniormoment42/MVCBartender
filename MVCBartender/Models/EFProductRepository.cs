using System.Collections.Generic;

namespace MVCBartender.Models
{
    public class EFProductRepository : IProductReporitory
    {
        private ApplicationDbContext context;

        public EFProductRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        } // end EFProductRepository constructor

        public IEnumerable<Product> Products => context.Products;
    } // end EFProductRepository Class
} // end MVCBartender.Models namespace
