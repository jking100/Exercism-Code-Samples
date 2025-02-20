using System;

public static class PhoneNumber
{
  /*
   * 1. An indication of whether the number has a New York dialing code ie. 212 as the first 3 digits
2. An indication of whether the number is fake having 555 as a prefix code in positions 5 to 7 (numbering from 1)
3. The last 4 digits of the number.
  */
  public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
  {
    string[] phoneParts = phoneNumber.Split('-');
    return ((phoneParts[0] == "212"), (phoneParts[1] == "555"), (phoneParts[2]));
  }

  public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
  {
    return phoneNumberInfo.IsFake;
  }
}
