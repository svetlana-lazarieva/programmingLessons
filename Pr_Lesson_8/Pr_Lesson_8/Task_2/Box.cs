using System;
/// <summary>
/// Создайте класс Box (ящик) – он является контейнером, может содержать в себе 
/// другие фигуры.  
/// В классе Box создайте поле типа  double  с именем DrawerVolume (Объем ящика), 
/// поле должно хранить в себе объём ящика.  Далее в классе Box  создайте метод Аdd(), 
/// который  принимает на вход объекты типа Shape, и возвращает значение типа boll. 
/// В классе Box реализуйте логику для добавления новых фигуры до тех пор, пока для них 
/// хватает места в Box (будем считать только объём, игнорируя форму, например, мы 
/// переливаем жидкость). Если места для добавления новой фигуры не хватает, 
/// то метод должен вернуть false. 
/// </summary>

namespace Task_2
{
    public class Box
    {
        private const int MinVal = 100;
        private const int MaxVal = 200;
        // Объем ящика
        private double _drawerVolume { get; set; }

        public Box()
        {
            Random randomVolume = new Random(Guid.NewGuid().GetHashCode());
            _drawerVolume = randomVolume.Next(MinVal, MaxVal);
            Console.WriteLine($"Наша коробка объёмом {_drawerVolume}");
        }

        /// <summary>
        /// Пытается создать фигуру и положить ее в коробку
        /// </summary>
        public void TryToAdd()
        {
            Shape shape = CreateShape();
            if (Add(shape))
            {
                TryToAdd();                
            }           
        }

        /// <summary>
        /// Проверяет есть ли место в ящике после создания фигуры
        /// </summary>
        /// <param name="shape"> Фигура </param>
        /// <returns>Есть ли место в ящике </returns>
        private bool Add(Shape shape)
        {
            bool isNotFull = true;
            double newShapeVolume = shape.GetVolume();
            shape.ShowShapeInfo();

            if (_drawerVolume >= newShapeVolume)
            {
                _drawerVolume -= newShapeVolume;
                Console.WriteLine("И положили её в ящик.");
            }
            else
            {
                Console.WriteLine("Фигура не поместилась в коробку.");
                Console.ReadKey();
                isNotFull = false;
            }
            return isNotFull;
        }

        /// <summary>
        /// Создает случайную фигуру
        /// </summary>
        /// <returns> Случайная фигура</returns>
        private Shape CreateShape()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int shapeId = random.Next(1, 3);
            switch (shapeId)
            {
                case 1:
                    {
                        Shape shape = new Cylinder();                       
                        return shape;
                    }
                case 2:
                    {
                        Shape shape = new Ball();
                        return shape;
                    }
                default:
                    {
                        Shape shape = new Pyramid();
                        return shape;
                    }
            }            
        }
    }
}
