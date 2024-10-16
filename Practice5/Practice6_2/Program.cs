using ClassLibrary;
using Practice6_2;
using System.Globalization;
using System.Linq.Expressions;

class Program
{
  static void Main()
  {
    var account = new Account(100);
    var savingAccount = new SavingsAccount(100);
    ChoiseAccount();

     void ChoiseAccount()
    {
      while (true)
      {
        Console.WriteLine("1. Обычный счет");
        Console.WriteLine("2. Накопительный счет");
        Console.WriteLine("3. Выход");
        Console.WriteLine("Выберите счет:");
        string choise = Console.ReadLine();

        switch (choise)
        {
          case "1":
            ChoiseActionAccount();
            break;
          case "2":
            ChoiseActionSavingsAccount();
            break;
          case "3":
            return;
          default:
            Console.WriteLine("Некорректный ввод. Попробуйте еще раз. Введите 1 или 2.");
            break;
        }
      }
    }

    void ChoiseActionAccount()
    {
      while (true)
      {
        Console.WriteLine("1. Пополнить счет");
        Console.WriteLine("2. Снять деньги со счета");
        Console.WriteLine("3. Выход");
        Console.WriteLine("Выберите действие:");
        string choise = Console.ReadLine();

        switch (choise)
        {
          case "1":
            Console.WriteLine("Какую сумму вы хотите внести?");
            decimal money = Convert.ToDecimal(Console.ReadLine());
            account.MakeDeposit(money);
            Console.WriteLine("Сумма внесена.");
            break;
          case "2":
            Console.WriteLine("Какую сумму вы хотите снять?");
            money = Convert.ToDecimal(Console.ReadLine());
            account.MakeWithdrawal(money);
            Console.WriteLine("Сумма снята.");
            break;
          case "3":
            return;
          default:
            Console.WriteLine("Некорректный ввод. Попробуйте еще раз. Введите 1 или 2.");
            break;
        }
      }
    }

    void ChoiseActionSavingsAccount()
    {
      while (true)
      {
        Console.WriteLine("1. Пополнить счет");
        Console.WriteLine("2. Снять деньги со счета");
        Console.WriteLine("3. Выход");
        Console.WriteLine("Выберите действие:");
        string choise = Console.ReadLine();

        switch (choise)
        {
          case "1":
            Console.WriteLine("Какую сумму вы хотите внести?");
            decimal money = Convert.ToDecimal(Console.ReadLine());
            savingAccount.MakeDeposit(money);
            Console.WriteLine("Сумма внесена.");
            break;
          case "2":
            Console.WriteLine("Какую сумму вы хотите снять?");
            money = Convert.ToDecimal(Console.ReadLine());
            savingAccount.MakeWithdrawal(money);
            Console.WriteLine("Сумма снята.");
            break;
          case "3":
            return;
          default:
            Console.WriteLine("Некорректный ввод. Попробуйте еще раз. Введите 1 или 2.");
            break;
        }
      }
    }
  }
}