using System.Collections.Generic;


namespace MVCBartender.Models
{
    public interface IProductReporitory
    {
        IEnumerable<Product> Products { get; }
    } // end IProductReporitory interface class
} // end MVCBartender.Models namespace
