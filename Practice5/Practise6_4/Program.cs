using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
class Program
{
  static async Task Main()
  {
    string filePath = "filet.txt";

    while (true)
    {
      try
    {
        if (IsFileLocked(filePath))
        {
          Console.WriteLine("Файл блокируется другой программой. Пожалуйста, подождите.");
          
            await Task.Delay(5000); 
          
          continue;
        }

        using (StreamReader sr = new StreamReader(filePath))
      {
        string text = sr.ReadToEnd();
        Console.WriteLine(text);
          break;
      }
    }
    catch(FileNotFoundException ex)
    {
      Console.WriteLine("Файл не найден: " + ex.Message);
        Console.Write("Пожалуйста, введите корректный путь к файлу: ");
        filePath = Console.ReadLine();
      }
      catch (IOException ex)
      {
        Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
        Console.Write("Пожалуйста, исправьте данные в файле или введите корректный путь к файлу: ");
        filePath = Console.ReadLine();
      }
      catch (Exception ex)
      {
        Console.WriteLine("Ошибка: " + ex.Message);
        Console.Write("Пожалуйста, исправьте данные в файле или введите корректный путь к файлу: ");
        filePath = Console.ReadLine();
      }
    }

    Console.ReadLine();
    static bool IsFileLocked(string filePath)
    {
      try
      {
        using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Write, FileShare.None))
        {
          stream.Close();
        }
        return false;
      }
      catch (IOException)
      {
        return true;
      }
    }
  }
}