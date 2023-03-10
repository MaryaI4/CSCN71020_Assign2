namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void SetWidth1()
        {
            int input = 33, width;
            if (input > 0 && input < 99)
            {
                width = input;
                Assert.AreEqual(input, input);
            }

            Assert.AreEqual(33, input);
        }


        [TestMethod]
        public void SetWidth2()
        {
            int input = -45, width;
            if (input > 0 && input < 99)
            {
                width = input;
                Assert.AreEqual(input, input);

            }
            Assert.AreEqual(88888, input);

        }
        [TestMethod]
        public void SetWidth3()
        {
            int input = 95, width;
            if (input > 0 && input < 99)
            {
                width = input;
                Assert.AreEqual(input, input);
            }
            Assert.AreEqual(95, input);
        }
        [TestMethod]
        public void lengthlimit1()
        {
            int input = 5, length;
            if (input > 0 && input < 99)
            {
                length = input;
                Assert.AreEqual(input, input);
            }
            Assert.AreEqual(5, input);

        }

        [TestMethod]

        public void lengthlimit2()
        {
            int input = -23, length;
            if (input > 0 && input < 99)
            {
                length = input;
                Assert.AreEqual(input, input);

            }
            Assert.AreEqual(9999999, input);
        }
        [TestMethod]

        public void lengthlimit3()
        {
            int input = 99, length;
            if (input > 0 && input < 99)
            {
                length = input;
                Assert.AreEqual(input, input);
            }
            Assert.AreEqual(99, input);
        }
    }
}