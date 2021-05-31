using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace Task_1
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону Console Application. 
    /// Создайте программу, в котором организуйте асинхронный вызов метода.
    /// Используя конструкцию BeginInvoke передайте в поток некоторую 
    /// информацию(возможно, в формате строки). 
    /// Организуйте обработку переданных данных в callback методе.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Func<string,string> myDelegate = new Func<string,string>(Method);
            myDelegate.BeginInvoke("jhk", CallBackMethod, null);
            Console.ReadKey();

        }

        /// <summary>
        /// Метод для выполнения в отдельном потоке.
        /// </summary>
        public static string Method(string str)
        {
            return $"{str} - строка";
        }

        /// <summary>
        /// Метод обработки завершения асинхронной операции.
        /// </summary>
        public static void CallBackMethod(IAsyncResult asyncResult)
        {
            AsyncResult ar = asyncResult as AsyncResult;
            Func<string, string> func =(Func<string, string>)ar.AsyncDelegate;
            // Получение результатов асинхронной операции.
            string res = func.EndInvoke(asyncResult);
            Console.WriteLine($"Результат асинхронной операции: {res}");

        }
    }
}
