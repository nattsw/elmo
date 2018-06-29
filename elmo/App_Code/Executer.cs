using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for Executer
/// </summary>
public class Executer
{
    LoggerBlock loggerBlock = new LoggerBlock();

    public void Execute()
    {
        WriteTraceLog("Execute something");
    }

    public void WriteTraceLog(String message)
    {
        loggerBlock.LogWriter.Write(message, "General", 5, 2000, TraceEventType.Information);
    }
}