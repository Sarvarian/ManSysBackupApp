using ManSysBackupAppLibTest.TestUtilities;
using Xunit.Abstractions;

namespace ManSysBackupAppLibTest
{
    public class UnitTest1 : TestBaseClass
    {
        [Fact]
        public void Test1()
        {
            TestLog.WriteLine($"pwd is: {TestDirectory.Pwd}");
        }

        public UnitTest1(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
        }
    }
}