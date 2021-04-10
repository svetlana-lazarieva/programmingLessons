using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Создайте программу, в которой создайте структуру с именем – Notebook (Блокнот), 
/// структура должна содержать следующие поля: модель, производитель, цена. 
/// В структуре реализуйте конструктор для инициализации полей и метод для вывода 
/// содержимого полей на экран. 
/// </summary>

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("A", "B", 23.5);
            notebook.Show();
        }
    }

    /// <summary>
    /// Блокнот
    /// </summary>
    public struct Notebook
    {
        private string _model;
        private string _manufacturer;
        private double _price;

        public Notebook(string model, string manufacturer, double price)
        {
            this._model = model;
            this._manufacturer = manufacturer;
            this._price = price;
        }
        public void Show()
        {
            Console.WriteLine($"{_model} {_manufacturer} {_price}");
            Console.ReadKey();
        }
    }

}
