namespace ManSysBackupAppLibTest.TestUtilities;
using Xunit.Abstractions;

public class TestBaseClass
{
	protected readonly ITestOutputHelper TestLog;

	public TestBaseClass(ITestOutputHelper testOutputHelper)
	{
		TestLog = testOutputHelper;
	}
}