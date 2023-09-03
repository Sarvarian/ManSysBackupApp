using Serilog;

namespace ManSysBackupAppLib;

public class Log
{

	public Log(string directory, string name)
	{
		var log = new Serilog.LoggerConfiguration()
			.WriteTo.Console()
			.WriteTo.File($"{directory}{name}")
			.CreateLogger();
	}

}