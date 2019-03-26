using CompareCostsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CompareCostsProject
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TariffProduct> list = Comparison(4500);

            list.ForEach(item =>
            {
                Console.WriteLine("Tariff name: {0}, annual cost: {1}", item.TariffName, item.AnnualCost);
            });

        }

        static List<TariffProduct> Comparison(int consumption)
        {
            List<TariffProduct> comparisonList = new List<TariffProduct>();

            Product productA = new ProductA();
            Product productB = new ProductB();

            TariffProduct tariffProductA = new TariffProduct(productA, consumption);
            TariffProduct tariffProductB = new TariffProduct(productB, consumption);

            comparisonList.Add(tariffProductA);
            comparisonList.Add(tariffProductB);

            return comparisonList.OrderBy(item => item.AnnualCost).ToList();
        }
    }
}
