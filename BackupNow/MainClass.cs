using ManSysBackupAppLib;

namespace BackupNow;

public class MainClass
{
	public static void Main(MainInitData initData)
	{
		var args = initData.args;
		var pwd = initData.pwd;

		
		var guid = Guid.NewGuid();
		
		// Log
		var log = new Log(pwd, $"log_{guid}");
		
		// Error
		PrepareError();
		
		// Read Arguments
		ConsiderCmdLineForScheduleArgument(args);
		
		// Read Config
		// Generate Config
		// Analyze Backup Directory and Previous Backups
		// Consider Schedule
		// Create Backup
		// Delete Backup

	}

	private static void ConsiderCmdLineForScheduleArgument(IReadOnlyList<string> args)
	{
		if (args.Count == 0)
		{
			// Manual Backup.
		}
		else if (string.Equals(args[0], "Schedule", StringComparison.CurrentCultureIgnoreCase))
		{
			// Scheduling Backup.
		}
		else
		{
			// Error that command line arguments are not valid.
		}
	}
	

	private static void PrepareError()
	{
		throw new NotImplementedException();
	}
	
}