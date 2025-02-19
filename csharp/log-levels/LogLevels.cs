using System;

static class LogLine
{
  public static string Message(string logLine)
  {
    //[level]: MESSAGE
    //split on ':' and trim whitespace
    string[] splitLine = logLine.Split(':', 2, StringSplitOptions.TrimEntries);
    return splitLine[1];
  }

  public static string LogLevel(string logLine)
  {
    string[] splitLine = logLine.Split(':', 2, StringSplitOptions.TrimEntries);
    //cut first and last chars then to lowercase
    return splitLine[0].Trim(['[', ']']).ToLower();
  }

  public static string Reformat(string logLine)
  {
    string message = Message(logLine);
    string level = LogLevel(logLine);

    return $"{message} ({level})";
  }
}
