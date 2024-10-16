using ClassLibrary;
using System.Globalization;
using System.Linq.Expressions;

class Program
{
  static void Main()
  {
    while (true)
    {
      Console.WriteLine("1. Ввод чисел с клавиатуры");
      Console.WriteLine("2. Ввод чисел из файла");
      Console.WriteLine("3. Выход");
      Console.WriteLine("Выберите действие:");
      string choise = Console.ReadLine();

      switch (choise)
      {
        case "1":
          Console.WriteLine("Введите два числа для деления:");
          while (true)
          {
            try
            {
              Console.WriteLine("Первое число: ");
              decimal x = Convert.ToDecimal(Console.ReadLine());
              Console.WriteLine("Второе число: ");
              decimal y = Convert.ToDecimal(Console.ReadLine());
              decimal result = x / y;
              Console.WriteLine($"Результат: {result}");
              break;
            }

            catch (DivideByZeroException)
            {
              Console.WriteLine("Ошибка: делить на ноль нельзя! Введите другие числа");
            }

            catch (FormatException)
            {
              Console.WriteLine("Ошибка: неверный формат данных! Введите число.");
            }
            catch (Exception ex)
            {
              Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
            }
          }
          break;

        case "2":
          try
          {
            Console.WriteLine("Введите название файла: ");
            string txtFile = Console.ReadLine();
            string fileContent = File.ReadAllText(txtFile);
            string[] numbers = fileContent.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            decimal first = Convert.ToDecimal(numbers[0]);
            decimal second = Convert.ToDecimal(numbers[1]);
            Console.WriteLine($"Первое число: {first}");
            Console.WriteLine($"Второе число: {second}");
            decimal resultFile = first / second;
            Console.WriteLine($"Результат: {resultFile}");
            break;
          }
          catch(FileNotFoundException)
          {
            Console.WriteLine("Ошибка: данный файл не найден");
          }
          catch (DivideByZeroException)
          {
            Console.WriteLine("Ошибка: делить на ноль нельзя!");
          }
          catch (FormatException)
          {
            Console.WriteLine("Ошибка: неверный формат данных! В файле не числа.");
          }

          catch (IndexOutOfRangeException)
          {
            Console.WriteLine("Ошибка: недостаточно данных в файле");
          }

          catch (Exception ex)
          {
            Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
          }

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