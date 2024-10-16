using Practise6_3;

class Program
{
  static void Main()
  {
    const int maxAttempts = 3;
    int attempts = 0;

    while (attempts < maxAttempts)
    {
      try
      {
        Console.WriteLine("Введите свой возраст:");
        int age = Convert.ToInt16(Console.ReadLine());

        if (age < 18)
          throw new YoungPersonException("Пользователь несовершеннолетний.");

        Console.WriteLine("Вы достигли совершеннолетия.");
        break;
      }
      catch (YoungPersonException ex)
      {
        attempts++;
        Console.WriteLine(ex.Message);
        if (attempts < maxAttempts)
        {
          Console.WriteLine($"У вас осталось {maxAttempts - attempts} попыток.");
        }

        else 
          throw new TooManyAttemptsException("Превышено количество попыток. Пожалуйста, попробуйте позже.");

      }
    }
  }
}