using CompareCostsProject.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculationModel.Test
{
    [TestClass]
    public class CalculationModel_Tests
    {
        [TestMethod]
        [DataRow(3500, 830)]
        [DataRow(4500, 1050)]
        [DataRow(6000, 1380)]
        public void Test_CalculationModelA(int consumption, int result)
        {
            ProductA pr = new ProductA();
            var resultingConsumption = pr.CalculationModel(consumption);

            Assert.AreEqual(result, resultingConsumption);

        }


        [TestMethod]
        [DataRow(3500, 800)]
        [DataRow(4500, 950)]
        [DataRow(6000, 1400)]
        public void Test_CalculationModelB(int consumption, int result)
        {

            ProductB pr = new ProductB();
            var resultingConsumption = pr.CalculationModel(consumption);

            Assert.AreEqual(result, resultingConsumption);
        }
    }
}
