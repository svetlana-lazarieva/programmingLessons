using System;


namespace Task_2
{
    /// <summary>
    /// Пирамида
    /// </summary>
    public class Pyramid:Shape
    {
        private const int MinVal = 1;
        private const int MaxVal = 10;

        // Площадь основания
        public double _pyramidBaseArea;
        // Высота пирамиды
        public double _pyramidHeight;

        public Pyramid()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            _pyramidBaseArea = random.Next(MinVal, MaxVal);
            _pyramidHeight = random.Next(MinVal, MaxVal);
            ShapeName = "'Пирамида'";
        }

        /// <summary>
        /// Расчитывает объём пирамиды
        /// </summary>
        /// <returns> Объём пирамиды</returns>
        public override double  GetVolume()
        {
            Volume = _pyramidBaseArea * _pyramidHeight / 3d;
            return this.Volume;
        }
    }
}
