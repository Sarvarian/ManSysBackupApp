using Xunit.Abstractions;

namespace ManSysBackupAppLibTest.TestUtilities;

public class TestDirectoryTest : TestBaseClass
{
	[Fact]
	public void Pwd_EndsWithACertainPath()
	{
		var dirNames = new[] { "ManSysBackupApp", "ManSysBackupAppLibTest", "bin", "Debug", "net6.0" };
		var expected = Path.Combine(dirNames);

		Assert.EndsWith(expected, TestDirectory.Pwd);
	}

	[Fact]
	public void Pwd_DirectoryExists()
	{
		Assert.True(Directory.Exists(TestDirectory.Pwd));
	}

	[Fact]
	public void SolutionDirectory_EndsWithACertainName()
	{
		Assert.EndsWith("ManSysBackupApp", TestDirectory.SolutionDirectory);
	}

	[Fact]
	public void SolutionDirectory_Exits()
	{
		Assert.True(Directory.Exists(TestDirectory.SolutionDirectory));
	}
	
	[Fact]
	public void ProjectDirectory_EndsWithACertainName()
	{
		var dirNames = new[] { "ManSysBackupApp", "ManSysBackupAppLibTest" };
		var expected = Path.Combine(dirNames);
		
		Assert.EndsWith(expected, TestDirectory.ProjectDirectory);
	}

	[Fact]
	public void ProjectDirectory_Exits()
	{
		Assert.True(Directory.Exists(TestDirectory.ProjectDirectory));
	}

	[Fact]
	public void TestDirectory_EndsWithACertainPath()
	{
		var dirNames = new[] { "ManSysBackupApp", "ManSysBackupAppLibTest", "TestDirectory", };
		var expected = Path.Combine(dirNames);
		
		Assert.EndsWith(expected, TestDirectory.Get);
	}

	[Fact]
	public void TestDirectory_Exists()
	{
		Assert.True(Directory.Exists(TestDirectory.Get));
	}

	[Fact]
	public void TestDirectory_CreatesIfNotExist()
	{
		Directory.Delete(TestDirectory.Get);
		Assert.True(Directory.Exists(TestDirectory.Get));
	}

	[Fact]
	public void DeleteTestDirectory()
	{
		var path = TestDirectory.Get;
		Assert.True(Directory.Exists(path));
		TestDirectory.DeleteTestDirectory();
		Assert.False(Directory.Exists(path));
	}

	public TestDirectoryTest(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
	}
}