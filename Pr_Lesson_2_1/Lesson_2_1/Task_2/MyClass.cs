
/// <summary>
/// Создайте программу в которой создайте класс MyClass<T>, содержащий 
/// статический фабричный метод - T FacrotyMethod(), который будет порождать 
/// экземпляры типа, указанного в качестве параметра типа 
/// (указателя места заполнения типом – Т).
/// </summary>

namespace Task_2
{
    public class MyClass<T> where T: new()
    {
        public static T FactoryMethod()
        {
            T val = new T();
            return val;
        }
    }
}
