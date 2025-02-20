using System;

/*
  Badge.Print(734, "Ernest Johnny Payne", "Strategic Communication");
  // => "[734] - Ernest Johnny Payne - STRATEGIC COMMUNICATION"
*/
static class Badge
{
  public static string Print(int? id, string name, string? department)
  {
    string idPart = id is null ? "" : $"[{id}] - ";
    string deptPart = department?.ToUpper() ?? "OWNER";
    return $"{idPart}{name} - {deptPart}";
  }
}
