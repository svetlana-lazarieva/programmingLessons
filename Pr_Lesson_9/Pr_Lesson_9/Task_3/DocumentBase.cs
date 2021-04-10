using System;
/// <summary>
/// Создайте базовый абстрактный класс Document (документ), в котором создайте 
/// три метода void Headline (Заголовок), DocumentСontent(Содержимое документ), 
/// Footer(подвал документа).
/// </summary>

namespace Task_3
{
    public abstract class DocumentBase
    {
        /// <summary>
        /// Заголовок
        /// </summary>
        public abstract void Headline();
        /// <summary>
        /// Содержимое документ
        /// </summary>
        public abstract void DocumentСontent();
        /// <summary>
        /// Подвал документа ))
        /// </summary>
        public abstract void Footer();
    }
}
