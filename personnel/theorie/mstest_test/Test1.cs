using System.Threading.Channels;
using testtest;

namespace mstest_test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void testThatSumOfTenAndTenIsTwenty()
        {
            //Arrgange
            int x = 10;
            int y = 10;
            int z = -15;

            //Act
            int res = MyMath.Somme(x, y);
            int res2 = MyMath.Somme(z, x);

            //Assert
            Assert.AreEqual(20, res);
            Assert.AreEqual(-5, res2);
        }
    }
}
