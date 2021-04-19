using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application. 
/// Создайте программу, в которой  создайте анонимный метод, который принимает 
/// в качестве аргумента массив делегатов и возвращает среднее арифметическое 
/// возвращаемых значений методов сообщенных с делегатами в массиве. 
/// Методы, сообщенные с делегатами из массива, возвращают случайное 
/// значение типа int.
/// </summary>

namespace Task_3
{
    class Program
    {
        

        /// <summary>
        /// Колличество элементов массива делигатов
        /// </summary>
        public const int NumberOfDelegates = 3;

        /// <summary>
        /// Делегат принимает в качестве аргумента число
        /// </summary>
        /// <param name="val1">Число</param>
        /// <returns>Числовое возвращаемое значение</returns>
        public delegate int  MyDelegate(int val1);
        static MyDelegate myDelegate;


        /// <summary>
        /// Делегат принимает как аргумент массив делегатов и возвращает среднее арифметическое
        /// </summary>
        /// <param name="myDelegates">Массив делегатов</param>
        /// <returns>Среднее арифметическое возвращаемых значений</returns>
        public delegate double ArrDelegate(MyDelegate[] myDelegates);
        static ArrDelegate arrDelegate;

        static void Main(string[] args)
        {
            // Массив делигатов           
            MyDelegate[] myDelegates = new MyDelegate[NumberOfDelegates];
            myDelegates = FillArrayOfDelegates(myDelegates);

            // Анонимный метод, который принимает в качестве аргумента массив 
            // делегатов и возвращает среднее арифметическое возвращаемых 
            // значений методов сообщенных с делегатами в массиве.
            arrDelegate = delegate (MyDelegate[] delegates)
            {
                Random rand = new Random();
                int summOfReturnedValues = 0;

                Console.WriteLine("Элементы массива: ");
                for (int i = 0; i < delegates.Length; i++)
                {
                    int val = rand.Next(1,10);
                    summOfReturnedValues += delegates[i].Invoke(val);
                    
                }

                return summOfReturnedValues / (double)delegates.Length; 
            };

            double res = arrDelegate.Invoke(myDelegates);

            Console.WriteLine($"\nСреднее арифметическое: {res}");
            Console.ReadKey();

        }

        /// <summary>
        /// Методов сообщенных с делегатами в массиве
        /// </summary>
        /// <param name="val">Число</param>
        /// <returns>Результирующее число</returns>
        public static int DoSomething(int val)
        {
            int res = val + 1;
            Console.Write($"{res} ");
            return res;
        }

        /// <summary>
        /// Заполняем массив делегатов делегатами сообщенными с методами
        /// </summary>
        /// <param name="delegates">Пустой массив делегатов</param>
        /// <returns>Заполненный массив делегатов</returns>
        public static MyDelegate[] FillArrayOfDelegates(MyDelegate[] delegates)
        {
            for (int i = 0; i < delegates.Length; i++)
            {
                delegates[i] = DoSomething;
            }
            return delegates;
        }

    }
}
