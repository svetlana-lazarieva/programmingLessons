using System;


namespace Task_2
{
    /// <summary>
    ///  Шар
    /// </summary>
    class Ball:Shape
    {
        private const int MinVal = 1;
        private const int MaxVal = 10;

        // Радиус шара
        private double _ballRadius;
        public Ball()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            _ballRadius = random.Next(MinVal, MaxVal);
            ShapeName = "'Шар'";
        }

        /// <summary>
        /// Расчитывает объём шара
        /// </summary>
        /// <returns> Объём шара</returns>
        public override double GetVolume()
        {
            Volume = Math.PI * 4 / 3d * Math.Pow(_ballRadius, 3);
            return this.Volume;
        }

    }
}
