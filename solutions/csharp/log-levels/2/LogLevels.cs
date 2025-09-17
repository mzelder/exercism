static class LogLine
{
    public static string Message(string logLine)
    {
        string[] array = logLine.Split(' ');
        return string.Join(" ", array[1..]).Trim();
    }

    public static string LogLevel(string logLine)
    {
        string[] array = logLine.Split(' ');
        return array[0].Trim('[',']', ':').ToLower();
    }

    public static string Reformat(string logLine)
    {
        string message = LogLine.Message(logLine);
        string error = LogLine.LogLevel(logLine);
        return $"{message} ({error})";
    }
}
