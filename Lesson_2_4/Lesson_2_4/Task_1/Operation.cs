using System;

namespace Task_1
{
    public class Operation<T>
    {
        private T _val1;
        private T _val2;

        private delegate dynamic OperationDelegate(T val1, T val2);
        /// <summary>
        /// Сложить
        /// </summary>
        private OperationDelegate Add;
        /// <summary>
        /// Вычесть
        /// </summary>
        private OperationDelegate Subtr;
        /// <summary>
        /// Умножить
        /// </summary>
        private OperationDelegate Mult;
        /// <summary>
        /// Разделить
        /// </summary>
        private OperationDelegate Div;

        public Operation(T val1, T val2)
        {
            
            _val1 = val1;
            _val2 = val2;

            Calculator<T> calculator = new Calculator<T>();
            Add += calculator.Sum;
            Subtr += calculator.Difference;
            Mult += calculator.Multiplication;
            Div += calculator.Division;
        }

        /// <summary>
        /// Определить операцию
        /// </summary>
        private static int GetOperation()
        {
            Console.WriteLine("Введите номер операции: \n1 - сложение \n2 - вычитание \n3 - умножение \n4 - деление");
            if (!int.TryParse(Console.ReadLine(), out int operation) ||
                (operation < 1 && operation > 4))
            {
                Console.WriteLine("Введенное значение не закреплено за знаком операции.");
                GetOperation();
            }

            return operation;
        }

        /// <summary>
        /// Выполнить заданную операцию
        /// </summary>
        public dynamic SetOperation(out string oper)
        {
            int operation = GetOperation();
            dynamic res = 0;
            oper = string.Empty;
            switch (operation)
            {
                case 1:
                    res = Add.Invoke(_val1, _val2);
                    oper = "+";
                    break;
                case 2:
                    res = Subtr.Invoke(_val1, _val2);
                    oper = "-";
                    break;
                case 3:
                    res = Mult.Invoke(_val1, _val2);
                    oper = "*";
                    break;
                case 4:
                    res = Div.Invoke(_val1, _val2);
                    oper = "/";
                    break;
            }
            return res;
        }

    }
}
