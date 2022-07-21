using DemoCICDSolution.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace DemoUnitTestPipeline
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new WeatherForecastController();
            var result = controller.Get();
            Assert.IsNull(result);
        }
    }
}