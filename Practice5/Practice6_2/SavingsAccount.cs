using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6_2
{
  public class SavingsAccount : BankAccount
  {
    public SavingsAccount(decimal balance):base(balance) { }

    public override void MakeDeposit(decimal deposit)
    {
      base.MakeDeposit(deposit);
    }

    public override void MakeWithdrawal(decimal money)
    {
      if (LastWithdrawalDate.Year == DateTime.Now.Year && LastWithdrawalDate.Month == DateTime.Now.Month)
        throw new WithdrawalLimitExceededException("Вы уже снимали деньги в этом месяце. Попробуйте в следующем.");

      base.MakeWithdrawal(money);
    }
  }
}
