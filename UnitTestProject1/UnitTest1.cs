using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator_for_codeship;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test_Add_4and9_result13()
        {

           Susu some =new Susu();
           int result = some.Add(4, 9);
           Assert.AreEqual(13,result);
        }

        [TestMethod]
        public void test_Mult_4and2_result8()
        {

            Susu some = new Susu();
            int result = some.Mult(4, 2);
            Assert.AreEqual(8, result);
        }
    }
}
