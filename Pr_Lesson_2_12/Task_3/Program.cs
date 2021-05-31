using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_3
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону Console Application
    /// Создайте два метода, которые будут выполняться в рамках параллельных задач.Организуйте
    /// вызов этих методов при помощи Invoke таким образом, чтобы основной поток программы
    /// (метод Main) не остановил свое выполнение
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поток Main: Id {0}", Thread.CurrentThread.ManagedThreadId);
            Action action = new Action(RunTasks);
            action.BeginInvoke(null, null);
            Console.WriteLine("Main продолжает работу");
            Console.ReadKey();
        }

        static void RunTasks()
        {
            ParallelOptions options = new ParallelOptions();
            options.MaxDegreeOfParallelism = 2;
            Console.WriteLine("Поток RunTasks(): Id {0}", Thread.CurrentThread.ManagedThreadId);
            Parallel.Invoke(options, Method1, Method2);
        }

        /* Я не совсем понимаю, почему в одном из этих методов ManagedThreadId до Sleep
           и после Sleep дает разный результат*/

        static void Method1()
        {
            Console.WriteLine($"Поток Method1(): Id {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(10000);
            Console.WriteLine($"Поток Method1(): Id {Thread.CurrentThread.ManagedThreadId} закончил работу");
        }
        static void Method2()
        {
            Console.WriteLine($"Поток Method2(): Id {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(8000);
            Console.WriteLine($"Поток Method2(): Id {Thread.CurrentThread.ManagedThreadId} закончил работу");
        }

    }
}
