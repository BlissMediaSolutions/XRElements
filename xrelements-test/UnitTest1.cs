using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using xrelements;

namespace xrelements_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_SH3_Order_Total()
        {
            //Test SH3 Order Total Calculation
            double expected = 8.98;
            SH3 order1 = new SH3(10, ProductCode.SH3);
            order1.Order(order1.Qty);

            Assert.AreEqual(expected, order1.Total);
        }

        [TestMethod]
        public void Test_YT2_Order_Total()
        {
            //Test YT2 Order Total Calculation
            double expected = 9.9;
            YT2 order2 = new YT2(8, ProductCode.YT2);
            order2.Order(order2.Qty);

            Assert.AreEqual(expected, order2.Total);
        }

        [TestMethod]
        public void Test_TR_Order_Total()
        {
            //Test TR Order Total Calculation
            double expected3 = 15.98;
            TR order3 = new TR(18, ProductCode.TR);
            order3.Order(order3.Qty);

            Assert.AreEqual(expected3, order3.Total);
        }
        
        [TestMethod]
        public void Test_SH3_Order_Total2()
        {
            //Test SH3 Order Total Calculation
            double expected = 2.99;
            SH3 order1 = new SH3(3, ProductCode.SH3);
            order1.Order(order1.Qty);

            Assert.AreEqual(expected, order1.Total);
        }
        
        [TestMethod]
        public void Test_YT2_Order_Total2()
        {
            //Test YT2 Order Total Calculation
            double expected = 27.9;
            YT2 order2 = new YT2(30, ProductCode.YT2);
            order2.Order(order2.Qty);

            Assert.AreEqual(expected, order2.Total);
        }  
    }    
}
