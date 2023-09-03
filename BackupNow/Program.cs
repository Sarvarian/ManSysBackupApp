
using BackupNow;

// (1)
// ##### Try
try
{
	// (2)
	// ##### Create initial Data for Main.
	var initData = new MainInitData()
	{
		args = args,
		pwd = Environment.CurrentDirectory,
	};
	
	// (3)
	// ##### Call Main
	MainClass.Main(initData);
	
// (4)
// ##### Catch
}
catch (Exception exception)
{
	HandleTopLevelException(exception);
}

// (5)
// ##### Notify User for unhandled exceptions.
void HandleTopLevelException(Exception exception)
{
	// TODO: Print the exception into a file beside the executable.
	// Or handle notify the user in someway. 
	throw exception;
}

