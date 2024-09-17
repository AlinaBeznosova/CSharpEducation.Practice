using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	/// <summary>
	/// Класс вывода логов в консоль.
	/// </summary>
	public class ConsoleLogger : ILogger
	{
		#region Поле
		/// <summary>
		/// Имя класса.
		/// </summary>
		private readonly string className;

		#endregion

		#region Методы

		/// <summary>
		/// Вывод лога в консоль.
		/// </summary>
		/// <param name="message">Сообщение лога.</param>
		/// <param name="logLevel">Уровень лога.</param>
		private void WriteLog(string message, LogLevel logLevel)
		{
			var logLevelString = logLevel.ToString();
			var logMessage = $"{DateTime.Now} | {className} | {logLevelString} | {message}";
			Console.WriteLine(logMessage);
		}

		/// <summary>
		/// Вывод лога полной информации отладки.
		/// </summary>
		/// <param name="message">Сообщение лога.</param>
		public void Trace(string message) => WriteLog(message, LogLevel.Trace);

		/// <summary>
		/// Вывод лога общей информации.
		/// </summary>
		/// <param name="message">Сообщение лога.</param>
		public void Info(string message) => WriteLog(message, LogLevel.Info);

		/// <summary>
		/// Вывод лога детальной информации отладки.
		/// </summary>
		/// <param name="message">Сообщение лога.</param>
		public void Debug(string message) => WriteLog(message, LogLevel.Debug);

		/// <summary>
		/// Вывод лога предупреждения.
		/// </summary>
		/// <param name="message">Сообщение лога.</param>
		public void Warning(string message) => WriteLog(message, LogLevel.Warning);

		/// <summary>
		/// Вывод лога ошибки.
		/// </summary>
		/// <param name="message">Сообщение лога.</param>
		public void Error(string message) => WriteLog(message, LogLevel.Error);

		/// <summary>
		/// Вывод лога критической ошибки.
		/// </summary>
		/// <param name="message">Сообщение лога.</param>
		public void Fatal(string message) => WriteLog(message, LogLevel.Fatal);

		/// <summary>
		/// Вывод лога с указанным уровнем важности.
		/// </summary>
		/// <param name="message">Сообщение лога.</param>
		/// <param name="logLevel">Уровень лога.</param>
		public void Log(string message, LogLevel logLevel) => WriteLog(message, logLevel);

		#endregion

		#region Конструктор

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="className">Имя класса.</param>
		public ConsoleLogger(string className)
		{
			this.className = className;
		}

		#endregion
	}
}
