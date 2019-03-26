using System;
using System.Collections.Generic;
using System.Text;

namespace CompareCostsProject.Models
{
    public class ProductA : Product
    {

        public ProductA() {
            Name = "Basic electricity tariff";
        }

        public override double CalculationModel(int consumption)
        {
            // base costs per month 5 € + consumption costs 22 cent/kWh
            return 5 * 12  + (consumption * 0.22);
        }
    }
}


