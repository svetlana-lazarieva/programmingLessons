using System;
using System.Collections.Generic;

/// <summary>
/// Класс Calculator должен содержать два универсальных параметра типа 
/// T1, T2 (Calculator<T1, T2>). 
/// В теле класса создайте методы для сложения, вычитания и умножения, которые 
/// в качестве аргументов должны принимать T1, T2, и возвращать тип double 
/// (можно использовать класс Convert или приведение типов)
/// </summary>


namespace Task_3
{
    public class Calculator<T1, T2>
    {
        /// <summary>
        /// Список допустимых типов
        /// </summary>
        List<Type> _supportedTypes = new List<Type>()
        {
            { typeof(short)},
            { typeof(int)},
            { typeof(long)},
            { typeof(double)},
            { typeof(float)},
        };

        /// <summary>
        /// Сложмить два значения
        /// </summary>
        /// <param name="val1">Значение1</param>
        /// <param name="val2">Значение2</param>
        /// <returns></returns>
        public double Addition(T1 val1, T2 val2)
        {
            if(IsSupportedType(val1, val2, out dynamic v1, out dynamic v2))
            {
                return v1 + v2;
            }
            return 0;
        }

        /// <summary>
        /// Найти разницу значений
        /// </summary>
        /// <param name="val1">Значение1</param>
        /// <param name="val2">Значение2</param>
        /// <returns></returns>
        public double Subtraction(T1 val1, T2 val2)
        {
            if (IsSupportedType(val1, val2, out dynamic v1, out dynamic v2))
            {
                return (double)(v1 - v2);
            }
            return 0;
        }

        /// <summary>
        /// Умножить два значения
        /// </summary>
        /// <param name="val1">Значение1</param>
        /// <param name="val2">Значение2</param>
        /// <returns></returns>
        public double Multiplication(T1 val1, T2 val2)
        {
            if (IsSupportedType(val1, val2, out dynamic v1, out dynamic v2))
            {
                return v1 * v2;
            }
            return 0;
        }

        /// <summary>
        /// Поддерживаются ли данные типы даных
        /// </summary>
        /// <param name="val1">Тип даных 1</param>
        /// <param name="val2">Тип даных 2</param>
        /// <returns></returns>
        private bool IsSupportedType(T1 val1, T2 val2, out dynamic v1, out dynamic v2)
        {          
            var t1Type = typeof(T1);
            var t2Type = typeof(T2);
            if (_supportedTypes.Contains(t1Type) &&
                _supportedTypes.Contains(t2Type))
            {
                v1 = (dynamic)val1;
                v2 = (dynamic)val2;
                return true;
            }
            else
            {
                throw new Exception("Not supported type exception.");
            }
        }

    }
}
