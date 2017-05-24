using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator_for_codeship;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test_Add_11and9_result20()
        {

           Susu some =new Susu();
           int result = some.Add(11, 9);
           Assert.AreEqual(20,result);
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
