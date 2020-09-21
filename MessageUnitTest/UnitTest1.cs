using BusinessLayer.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MoqUnitTestApi.Controllers;

namespace MessageUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            var mockForMessageLayer = new Mock<IMessageManager>();
            mockForMessageLayer.Setup(x => x.Add(It.IsAny<int>(), It.IsAny<int>())).Returns(25);
            ValuesController valuesController = new ValuesController(mockForMessageLayer.Object);
            var response = valuesController.Message();
            Assert.AreEqual("Values greater than 5", response);
        }
    }
}
