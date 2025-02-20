using System;

/*
  Badge.Print(734, "Ernest Johnny Payne", "Strategic Communication");
  // => "[734] - Ernest Johnny Payne - STRATEGIC COMMUNICATION"
*/
static class Badge
{
  public static string Print(int? id, string name, string? department)
  {

    return $"{(id is null ? "" : $"[{id}] - ")}{name} - {department?.ToUpper()}";
    //throw new NotImplementedException("Please implement the (static) Badge.Print() method");
  }
}
