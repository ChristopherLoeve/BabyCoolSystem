using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabyLibrary;

namespace BabyCoolSystemTest
{
    [TestClass]
    public class BabyCoolTest
    {
        [TestMethod]
        [DataRow(15, "normal")]
        [DataRow(12, "normal")] // lower limit for "normal"
        [DataRow(18, "normal")] // upper limit for "normal"
        [DataRow(11, "kritisk lav")] // 1 below lower limit
        [DataRow(19, "kritisk høj")] // 1 below lower limit
        public void AlarmBreathTest(int bpm, string expectedResult)
        {
            var result = BabyCool.AlarmBreath(bpm);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(0, false)]
        [DataRow(1, true)]
        [DataRow(-1, false)]
        [DataRow(2, false)]
        [DataRow(15, false)]
        public void AlarmCryTest(int cry, bool expectedResult)
        {
            var result = BabyCool.AlarmCry(cry);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
