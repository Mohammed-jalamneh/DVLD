using System;
using System.Diagnostics;

public static class clsEventLogger
{
    private static readonly string _sourceName = "DVLD";
    private static readonly string _logName = "Application";

    public static void LogException(Exception ex)
    {
        try
        {
            if (!EventLog.SourceExists(_sourceName))
            {
                EventLog.CreateEventSource(_sourceName, _logName);
            }

            string errorMessage = $"Message: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}";
            if (ex.InnerException != null)
            {
                errorMessage += $"\n\nInner Exception: {ex.InnerException.Message}";
            }

            EventLog.WriteEntry(_sourceName, errorMessage, EventLogEntryType.Error);
        }
        catch (System.Security.SecurityException)
        {
            try
            {
                EventLog.WriteEntry("Application", $"[DVLD Error] {ex.Message}\n{ex.StackTrace}", EventLogEntryType.Error);
            }
            catch
            {
            }
        }
        catch (Exception)
        {
        }
    }
}