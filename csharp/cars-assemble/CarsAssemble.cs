using System;

static class AssemblyLine
{
  public static double SuccessRate(int speed)
  {
    /*
     - `0`: 0% success rate.
- `1` to `4`: 100% success rate.
- `5` to `8`: 90% success rate.
- `9`: 80% success rate.
- `10`: 77% success rate.
     */
    if (speed == 0)
    {
      return 0;
    }
    else if (speed >= 1 && speed <= 4)
    {
      return 1.0;
    }
    else if (speed >= 5 && speed <= 8)
    {
      return .90;
    }
    else if (speed == 9)
    {
      return .80;
    }
    else
    {
      return .77;
    }
  }

  public static double ProductionRatePerHour(int speed) =>
    (221 * speed * SuccessRate(speed));

  public static int WorkingItemsPerMinute(int speed) =>
    (int)(ProductionRatePerHour(speed) / 60);
}
