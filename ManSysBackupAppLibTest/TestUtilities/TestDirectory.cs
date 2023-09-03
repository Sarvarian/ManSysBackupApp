namespace ManSysBackupAppLibTest.TestUtilities;

public static class TestDirectory
{
	public static string Pwd => Environment.CurrentDirectory;
	public static string ProjectDirectory => Path.GetFullPath("../../..", Pwd);
	public static string SolutionDirectory => Path.GetFullPath("../../../..", Pwd);
	
	public static string Get => GetTestDirectory();
	
	public static void DeleteTestDirectory()
	{
		Directory.Delete(GetTestDirectory());
	}
	
	private static string GetTestDirectory()
	{
		var path = Path.Combine(ProjectDirectory, "TestDirectory");
		Directory.CreateDirectory(path);
		return path;
	}

}