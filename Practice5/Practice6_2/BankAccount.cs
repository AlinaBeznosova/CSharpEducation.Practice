using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practice6_2
{
  public class BankAccount
  {
    
    public DateTime LastWithdrawalDate { get; protected set; }
    public decimal Balance { get; set; }
    public virtual void MakeDeposit(decimal deposit)
    {
      if (deposit < 0)
        throw new NegativeAmountException("Внесенная сумма не может быть отрицательной");

      Balance += deposit;
      Console.WriteLine($"Deposited {deposit}. Balance: {Balance}");
    }

    public virtual void MakeWithdrawal(decimal money)
    {
      if (money < 0)
        throw new NegativeAmountException("Снимаемая сумма не может быть отрицательной.");

      if (Balance - money < 0)
      {
        throw new InsufficientBalanceException("Недостаточно средств на счете.");
      }
      
        Balance -= money;
      LastWithdrawalDate = DateTime.Now;
      Console.WriteLine($"Withdrew {money}. Balance: {Balance}");
    }

    public BankAccount(decimal balance)
    {
      if (balance < 0)
        throw new NegativeAmountException("Баланс не может быть отрицательным.");
      Balance = balance;
    }
  }
}
