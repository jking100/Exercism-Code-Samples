using System;

static class SavingsAccount
{
  /*
   - 3.213% for a negative balance (balance gets more negative).
- 0.5% for a positive balance less than `1000` dollars.
- 1.621% for a positive balance greater than or equal to `1000` dollars and less than `5000` dollars.
- 2.475% for a positive balance greater than or equal to `5000` dollars.
   */
  public static float InterestRate(decimal balance) =>
    balance switch
    {
      < 0m => 3.213f,
      < 1000 and >= 0 => .5f,
      < 5000 and >= 1000 => 1.621f,
      _ => 2.475f
    };

  public static decimal Interest(decimal balance)
  {
    throw new NotImplementedException("Please implement the (static) SavingsAccount.Interest() method");
  }

  public static decimal AnnualBalanceUpdate(decimal balance)
  {
    throw new NotImplementedException("Please implement the (static) SavingsAccount.AnnualBalanceUpdate() method");
  }

  public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
  {
    throw new NotImplementedException("Please implement the (static) SavingsAccount.YearsBeforeDesiredBalance() method");
  }
}
