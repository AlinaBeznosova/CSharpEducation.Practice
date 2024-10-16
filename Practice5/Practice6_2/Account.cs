using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6_2
{
  public class Account :BankAccount
  {
    public override void MakeDeposit(decimal deposit)
    { 
      base.MakeDeposit(deposit); 
    }

    public override void MakeWithdrawal(decimal money)
    {
      base.MakeWithdrawal(money);
    }
    public Account(decimal balance) :base(balance)
    { }
  }
}
