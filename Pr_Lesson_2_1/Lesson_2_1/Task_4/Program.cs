﻿
/// <summary>
/// Является ли сравнение time и null в выражении if валидным? Почему?
/// </summary>

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             DateTime - структура. Структуры хранятся в стеке и не могут быть null никогда.
             При сравнении структуры с чем-то сравнивается ВСЯ структура, а не ссылка на нее,
             как если бы это был класс, например. Это значит, что если структура существует, 
             то она точно не null.
             */



            // DateTime time;
            //if (time == null)
            //{
            //    /* do something */
            //}

        }
    }
}
