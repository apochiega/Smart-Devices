
using AdapterExample;
using NUnit.Framework;

namespace Tests
{
    /// <summary>
    /// Tests
    /// </summary>
    public class SmartDevicesTests
    {
        /// <summary>
        /// Se testea Adapter
        /// </summary>
        [Test]
        public void AdapterTest()
        {
            Plug plug = new Plug("4564");
            ISmartDevice SmartPlug = new Adapter(plug);
            SmartPlug.Off();
            SmartPlug.On();
            Assert.AreEqual(SmartPlug.GetStatus(), "on");
        }
    }

    public class TestWashingMachine
    {
        /// <summary>
        /// Se testéa WashingMachine
        /// </summary>
        [Test]
        public void WashingMachineTest()
        {
            WashingMachine washingMachine = new WashingMachine("456");
            Assert.AreEqual("456", washingMachine.id);
            Assert.AreEqual("off", washingMachine.status);
            washingMachine.On();
            Assert.AreEqual("on", washingMachine.status);
            washingMachine.Off();
            Assert.AreEqual("off", washingMachine.status);
        }
    }

    public class TestBulb
    {
        /// <summary>
        /// Se testéa Bulb
        /// </summary>
        [Test]
        public void BulbTest()
        {
            Bulb bulb = new Bulb("321");
            Assert.AreEqual("321", bulb.id);
            Assert.AreEqual("off", bulb.status);
            bulb.On();
            Assert.AreEqual("on", bulb.status);
            bulb.Off();
            Assert.AreEqual("off", bulb.status);
        }
    }
}