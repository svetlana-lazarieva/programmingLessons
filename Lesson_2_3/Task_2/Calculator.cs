
namespace Task_2
{
    
    /// <summary>
    /// Калькулятор
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Calculator<T>
    {
        public delegate T MathOperationDelegate(T val1, T val2);
        public MathOperationDelegate Add;
        public MathOperationDelegate Subtr;
        public MathOperationDelegate Multiplicate;
        public MathOperationDelegate Div;

        /// <summary>
        /// Сложение
        /// </summary>
        /// <param name="val1">Значение 1</param>
        /// <param name="val2">Значение 2</param>
        /// <returns>Результат операции</returns>
        public T Addition(T val1, T val2)
        {
            return Add.Invoke(val1, val2);
        }

        /// <summary>
        /// Вычитание
        /// </summary>
        /// <param name="val1">Значение 1</param>
        /// <param name="val2">Значение 2</param>
        /// <returns>Результат операци</returns>
        public T Subtraction(T val1, T val2)
        {
            return Subtr.Invoke(val1, val2);
        }

        /// <summary>
        /// Умножение
        /// </summary>
        /// <param name="val1">Значение 1</param>
        /// <param name="val2">Значение 2</param>
        /// <returns>Результат операци</returns>
        public T Multiplication(T val1, T val2)
        {
            return Multiplicate.Invoke(val1, val2);
        }

        /// <summary>
        /// Деление
        /// </summary>
        /// <param name="val1">Значение 1</param>
        /// <param name="val2">Значение 2</param>
        /// <returns>Результат операци</returns>
        public T Division(T val1, T val2)
        {
            return Div.Invoke(val1, val2);
        }

    }
}
