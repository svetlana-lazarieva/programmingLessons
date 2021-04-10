using System;
using System.Collections.Generic;
/// <summary>
/// Создайте программу, в которой создайте класс AbstractHandler. 
/// В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). 
/// 
/// Написать логику, которая будет выполнять определение документа и 
/// для каждого формата должны быть методы открытия, создания, редактирования, сохранения 
/// определенного формата документа.
/// </summary>

namespace Task_4
{
    public abstract class AbstractHandler
    {
        /// <summary>
        /// Открыть
        /// </summary>
        public abstract void Open();
        /// <summary>
        /// Создать
        /// </summary>
        public abstract void Create();
        /// <summary>
        /// Изменить
        /// </summary>
        public abstract void Change();
        /// <summary>
        /// Сохранить
        /// </summary>
        public abstract void Save();

        /// <summary>
        /// Определение документа и для каждого формата должны быть методы 
        /// открытия, создания, редактирования, сохранения 
        /// определенного формата документа.
        /// </summary>
        public static AbstractHandler GetInstance<T>(List<AbstractHandler> handlers) 
            where T : AbstractHandler
        {
            foreach (var handler in handlers)
            {
                if (handler is T)
                {
                    Console.WriteLine($"\nНайден инстанс типа {handler.GetType().Name}");
                    return handler;
                }
            }

            return null;
           
        }
    }
}
