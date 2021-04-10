using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Создайте программу, в которой, создайте структуру с именем Price, 
/// содержащую следующие поля: 
/// название товара, название магазина, в котором продается товар, тоимость 
/// товара в гривнах. 
/// 
/// Написать логику, которая будет выполнять следующие действия: 
/// 1) ввод с клавиатуры данных в массив, состоящий из двух элементов типа Price 
/// (записи должны быть упорядочены в алфавитном порядке по названиям магазинов); 
/// 2) вывод на экран информации о товарах, продающихся в магазине, название которого 
/// введено с клавиатуры (если такого магазина нет, вывести исключение).
/// </summary>

namespace Task_3
{
    /// <summary>
    /// Цены товаров в магазинах
    /// </summary>
    public struct Price:IComparable<Price>
    {
        public string ProductName { get; set; }
        public string StoreName { get; set; }
        public double Cost { get; set; }

        int IComparable<Price>.CompareTo(Price other)
        {
            return String.Compare(StoreName, other.StoreName);
        }
    }

    /// <summary>
    /// Торговый центр
    /// </summary>
    public class ShoppingMall
    {
        private Price[] _stores= new Price[7];
        private const string ProductNameInfoType = "название товара";
        private const string StoreNameInfoType = "название магазина";
        private const string CostInfoType = "стоимость товара";

        /// <summary>
        /// Проверить торговый центр
        /// </summary>
        public void ProcessStoresArray()
        {
            FillStoresArray();
            ShowStoresArray();
        }

        /// <summary>
        /// Показать информацию о товарах в магазине торгового центра
        /// </summary>
        private void ShowStoresArray()
        {
            Console.Write($"\nВведите {StoreNameInfoType}: ");
            string name = Console.ReadLine();

            if (Array.Exists<Price>(_stores, x => x.StoreName == name))
            {
                var selectedInfo = _stores.Where(x => x.StoreName == name);
                List <Price> prices = selectedInfo.ToList();
                foreach (var item in prices)
                {
                    Console.WriteLine($"{item.ProductName} {item.Cost}");
                }
            }
            else
            {
                throw new Exception("Нет такого магазина.");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Заполнить массив магазинов трогового центра
        /// </summary>
        private void FillStoresArray()
        {
            for (int i = 0; i < _stores.Length; i++)
            {
                SetInfo(out string productName, out string storeName, out double cost);
                _stores[i].StoreName = storeName;
                _stores[i].ProductName = productName;
                _stores[i].Cost = cost;
            }
            Array.Sort(_stores, (x, y) => string.Compare(x.StoreName, y.StoreName));
        }

        /// <summary>
        /// Задать информацию о магазине торгового центра
        /// </summary>
        /// <param name="productName">Название товара</param>
        /// <param name="storeName">Название магазина</param>
        /// <param name="cost">Цена товара</param>
        private void SetInfo(out string productName, out string storeName, out double cost)
        {
            GetInfo(out storeName, StoreNameInfoType);
            GetInfo(out productName, ProductNameInfoType);            
            GetInfo(out cost, CostInfoType);
        }

        /// <summary>
        /// Получить информацию о магазине торгового центра
        /// </summary>
        /// <param name="info">Полученная информация</param>
        /// <param name="typeOfInfo">Вид информации</param>
        private void GetInfo(out string info, string typeOfInfo)
        {
            Console.Write($"Введите {typeOfInfo}: ");
            info = Console.ReadLine();
        }
        /// <summary>
        /// Получить информацию о магазине торгового центра
        /// </summary>
        /// <param name="info">Полученная информация</param>
        /// <param name="typeOfInfo">Вид информации</param>
        private void GetInfo(out double info, string typeOfInfo)
        {
            Console.Write($"Введите {typeOfInfo}: ");
            try
            {
                info = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GetInfo(out info, typeOfInfo);
            }  
        }

    }
}
