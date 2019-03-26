using System;
using System.Collections.Generic;
using System.Text;

namespace CompareCostsProject.Models
{
    public abstract class Product
    {
        public string Name { get; set; }

        public abstract double CalculationModel(int consumption);
    }
}
