using System;


namespace Task_2
{
    /// <summary>
    /// Цилиндр
    /// </summary>
    public class Cylinder: Shape
    {
        private const int MinVal = 1;
        private const int MaxVal = 10;

        // Площадь основания
        private double _cylinderBaseArea;
        // Высота цилиндра
        private double _cylinderHeight;
        public Cylinder()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            _cylinderBaseArea = random.Next(MinVal, MaxVal);
            _cylinderHeight = random.Next(MinVal, MaxVal);
            ShapeName = "'Цилиндр'";
        }

        /// <summary>
        /// Расчитывает объём цилиндра
        /// </summary>
        /// <returns> Объём цилиндра</returns>
        public override double GetVolume()
        {
            Volume = _cylinderBaseArea * _cylinderHeight;
            return this.Volume;
        }
    }
}
