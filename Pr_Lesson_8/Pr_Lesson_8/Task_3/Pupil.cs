using System;
/// <summary>
/// Создайте класс ученик Pupil.
/// В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().
/// </summary>

namespace Task_3
{
    public abstract class Pupil
    {
        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();

        /// <summary>
        /// Дела ученика
        /// </summary>
        /// <param name="pupil"> Ученик</param>
        public void PupilActivity(Pupil pupil)
        {
            this.Read();
            this.Write();
            this.Study();
            this.Relax();
        }

    }
}
