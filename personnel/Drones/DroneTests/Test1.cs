using Drones;

namespace DroneTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Drone testdrone = new Drone(10, 10, "test");
        }
    }
}
