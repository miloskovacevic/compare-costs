using System;
using System.Collections.Generic;
using System.Text;

namespace CompareCostsProject.Models
{
    public class TariffProduct
    {
        public string TariffName { get; set; }
        public double AnnualCost { get; set; }
        public Product Product   { get; set; }

        public TariffProduct(Product product, int consumption)
        {
            Product = product;
            TariffName = product.Name;
            AnnualCost = product.CalculationModel(consumption);
        }
    }
}
