static class LogLine
{
    public static string Message(string logLine)
    {
        string[] array = logLine.Split(' ');
        string result = string.Join(" ", array[1..]);
        return result.Trim();
    }

    public static string LogLevel(string logLine)
    {
        string[] array = logLine.Split(' ');
        string result = array[0].Trim('[',']', ':').ToLower();
        return result;
    }

    public static string Reformat(string logLine)
    {
        string message = LogLine.Message(logLine);
        string error = LogLine.LogLevel(logLine);
        string result = $"{message} ({error})";
        return result;
    }
}
