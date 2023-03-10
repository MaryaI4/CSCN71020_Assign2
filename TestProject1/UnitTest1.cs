namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int length = 10;
            int width = 20;
            int result = 2 * (length + width);
            Assert.AreEqual(60, result);


        }

        [TestMethod]
        public void TestMethod2()
        {
            int length = 10;
            int width = 20;
            int result = (length * width);

            Assert.AreEqual(200, result);

        }
    }
}

       