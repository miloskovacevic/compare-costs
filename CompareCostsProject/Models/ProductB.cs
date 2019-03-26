using System;
using System.Collections.Generic;
using System.Text;

namespace CompareCostsProject.Models
{
    public class ProductB : Product
    {
        public ProductB()
        {
            Name = "Packaged tariff”";
        }

        public override double CalculationModel(int consumption)
        {
            // 800 € for up to 4000 kWh/year and above 4000 kWh/year additionally 30 cent/kWh
            if (consumption <= 4000)
                return 800;
            else
            {
                int rest = consumption - 4000;

                return 800 + rest * 0.3;
            }
        }
    }
}
