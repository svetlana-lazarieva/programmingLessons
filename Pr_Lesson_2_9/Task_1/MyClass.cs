using System;

namespace Task_1
{
    public class MyClass
    {
        private string _someString1;

        public MyClass(string str1)
        {
            _someString1 = str1;
        }

        public void ShowStr1()
        {
            Console.WriteLine($"{_someString1}_new");
        }

        [Obsolete("Устаревший метод", false)]
        public void ShowStr2()
        {
            Console.WriteLine($"{_someString1}_old");
        }

        [Obsolete("Устаревший метод", true)]
        public void ShowStr3()
        {
            Console.WriteLine($"{_someString1}_wrong");           
        }
    }
}
