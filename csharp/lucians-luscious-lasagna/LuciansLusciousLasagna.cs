class Lasagna
{
  // TODO: define the 'ExpectedMinutesInOven()' method
  public int ExpectedMinutesInOven()
  {
    return 40;
  }

  // TODO: define the 'RemainingMinutesInOven()' method
  public int RemainingMinutesInOven(int elapsedTime)
  {
    return this.ExpectedMinutesInOven() - elapsedTime;
  }
  // TODO: define the 'PreparationTimeInMinutes()' method
  public int PreparationTimeInMinutes(int layers)
  {
    return layers * 2;
  }

  // TODO: define the 'ElapsedTimeInMinutes()' method
  public int ElapsedTimeInMinutes(int layers, int cookTime)
  {
    return PreparationTimeInMinutes(layers) + cookTime;
  }
}
