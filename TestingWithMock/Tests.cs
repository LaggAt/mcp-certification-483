using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestingWithMock
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void MoqInterfaceTest()
        {
            var mock = new Mock<InterfaceToMock>();
            mock.SetupGet(m => m.Five).Returns(5);
            mock.Setup(m => m.GetFive()).Returns(5);

            InterfaceToMock intf = mock.Object;

            Assert.AreEqual(5, intf.Five);
            Assert.AreEqual(5, intf.GetFive());

            // GetFive should return 6 now:
            mock.Setup(m => m.GetFive()).Returns(6);
            Assert.AreEqual(6, intf.GetFive());
        }


        [Test]
        public void MoqTest()
        {
            var mockCls = new Mock<UnfinishedClass>();
            mockCls.SetupGet(m => m.PropReturning6).Returns(1);
            mockCls.Setup(m => m.UnfinishedMethod(It.IsAny<int>())).Returns( (int i) => i*2 );
            mockCls.Setup(m => m.UnfinishedMethod(2)).Returns(2);

            UnfinishedClass inst = mockCls.Object;

            Assert.AreEqual(1, inst.PropReturning6);
            Assert.AreEqual(2, inst.UnfinishedMethod(2));
            Assert.AreEqual(6, inst.UnfinishedMethod(3));
        }
    }
}
