using ClassMockCore;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ClassMokCore.Test
{
    [TestClass]
    public class ConsumerTest
    {
        [TestMethod]
        public void StrTwoTimes()
        {
            Mock<ToBeMocked> mockToBeMocked = new Mock<ToBeMocked>();
            Locator.GetToBeMocked = () => mockToBeMocked.Object;
            mockToBeMocked.Setup(
                mtbm=> mtbm.TwoTimes(It.IsAny<int>())
                ).Returns(9);


            Consumer consumer = new Consumer();

            consumer.StrTwoTimes(3).Should().Be("9");
        }


    }
}
