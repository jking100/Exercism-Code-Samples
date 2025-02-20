using System;

public static class LogAnalysis
{
  static string[] LogLevels = ["INFO", "WARNING", "ERROR"];

  // TODO: define the 'SubstringAfter()' extension method on the `string` type
  public static string SubstringAfter(this string str, string delim)
  {
    return str.Split(delim)[1];
  }

  // TODO: define the 'SubstringBetween()' extension method on the `string` type
  public static string SubstringBetween(this string str, string firstDelim, string secondDelim)
  {
    return str.Split([firstDelim, secondDelim], StringSplitOptions.None)[1];
  }
  // TODO: define the 'Message()' extension method on the `string` type
  public static string Message(this string str) =>
    (str[(str.IndexOf(':') + 1)..].Trim());
  // TODO: define the 'LogLevel()' extension method on the `string` type
}