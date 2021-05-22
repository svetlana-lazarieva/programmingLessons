using System;


namespace Task_2
{
    /// <summary>
    /// Перечень уровней доступа
    /// </summary>
    public enum AccessLevelType
    {
        high,
        average,
        low
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    class AccessLevelAttribute : Attribute
    {
        /// <summary>
        /// Уровень доступа
        /// </summary>
        public AccessLevelType LevelType { get; private set; }

        public AccessLevelAttribute(AccessLevelType levelType)
        {
            this.LevelType = levelType;
        }
    }
}
