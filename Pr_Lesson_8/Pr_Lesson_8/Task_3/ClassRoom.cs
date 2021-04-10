using System;
using System.Collections.Generic;
/// <summary>
/// Требуется: Создать класс, представляющий учебный класс ClassRoom.
/// Конструктор класса ClassRoom принимает аргументы типа Pupil, 
/// класс должен состоять из 4 учеников. Предусмотрите возможность того, что 
/// пользователь может передать 2 или 3 аргумента. Выведите информацию о том, 
/// как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.
/// </summary>

namespace Task_3
{
    public class ClassRoom
    {
        // Количество учеников в классе
        private const int MaxQuantityOfPupil = 4;

        public Pupil Pupil1 { get; protected set; }
        public Pupil Pupil2 { get; protected set; }
        public Pupil Pupil3 { get; protected set; }
        public Pupil Pupil4 { get; protected set; }

        public ClassRoom(Pupil pupil1 = null, Pupil pupil2 = null, Pupil pupil3 = null, Pupil pupil4 = null)
        {
            // Массив интересующих нас учеников
            Pupil[] arrayOfPupil = CreateArrayOfPupil();

            // Нужна ли информация о конкретном ученике
            if (arrayOfPupil[0] != null)
            {
                pupil1 = arrayOfPupil[0];
            }
            if (arrayOfPupil[1] != null)
            {
                pupil2 = arrayOfPupil[1];
            }
            if (arrayOfPupil[2] != null)
            {
                pupil3 = arrayOfPupil[2];
            }
            if (arrayOfPupil[3] != null)
            {
                pupil4 = arrayOfPupil[3];
            }

            Pupil1 = pupil1;
            Pupil2 = pupil2;
            Pupil3 = pupil3;
            Pupil4 = pupil4;
        }

        /// <summary>
        /// Показать информацию о учениках класса
        /// </summary>
        /// <param name="pupil1"> Ученик 1 </param>
        /// <param name="pupil2"> Ученик 2 </param>
        /// <param name="pupil3"> Ученик 3 </param>
        /// <param name="pupil4"> Ученик 4 </param>
        public void ShowInfo()
        {
            Console.WriteLine();
            ShowThisPupil(Pupil1);
            ShowThisPupil(Pupil2);
            ShowThisPupil(Pupil3);
            ShowThisPupil(Pupil4);
            Console.ReadKey();
        }


        /// <summary>
        /// Показать информацию о конкретном ученике
        /// </summary>
        /// <param name="pupil"> Ученик </param>
        private void ShowThisPupil(Pupil pupil)
        {
            if (pupil != null)
            {
                pupil.PupilActivity(pupil);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Заполнить массив учеников
        /// </summary>
        /// <param name="arrayOfPupil"></param>
        /// <returns> Заполненый массив учеников </returns>
        private Pupil[] FillArrayOfPupil(Pupil[] arrayOfPupil, int quantityOfPupil)
        {
            for (int i = 0; i < quantityOfPupil; i++)
            {
                // Индекс ученика
                int pupilIndex = GetPupilIndex();
                arrayOfPupil[i] = GetTipeOfPupil(pupilIndex);
            }

            return arrayOfPupil;
        }

        /// <summary>
        /// Создать массив учеников
        /// </summary>
        /// <returns> Массив учеников </returns>
        private Pupil[] CreateArrayOfPupil()
        {
            // Массив учеников
            Pupil[] arrayOfPupil = new Pupil[MaxQuantityOfPupil];

            Console.WriteLine(" О скольки учениках Вы хотите узнать? В классе 4 ученика.");
            if (!int.TryParse(Console.ReadLine(), out int quantityOfPupil)
                || quantityOfPupil > 4 || quantityOfPupil < 1)
            {
                Console.WriteLine(" Введенное значение не корректно.\n В классе только 4 ученика. Поробуйте еще раз.\n");
                CreateArrayOfPupil();
            }
            else
            {
                arrayOfPupil = FillArrayOfPupil(arrayOfPupil, quantityOfPupil);
            }

            return arrayOfPupil;
        }

        /// <summary>
        /// Получаем индекс ученика
        /// </summary>
        /// <returns> Индекс ученика </returns>
        private int GetPupilIndex()
        {
            Console.WriteLine(" Какой это ученик? \n 1 - отличный \n 2 - хорший \n Что-то другое - плохой");
            if (!int.TryParse(Console.ReadLine(), out int pupilIndex))               
            {
                Console.WriteLine(" Нет таких учеников в классе. Поробуйте еще раз.");
                GetPupilIndex();
            }

            return pupilIndex;
        }

        /// <summary>
        ///  Создает ученика конкретного типа(отличный, хорший, плохой) по индексу ученика
        /// </summary>
        /// <param name="pupilIndex"> Индекс типа ученика </param>
        /// <returns>Ученик</returns>
        private Pupil GetTipeOfPupil(int pupilIndex)
        {
            Pupil tipeOfPupil;
            switch (pupilIndex)
            {
                case 1:
                    {
                        tipeOfPupil = new ExcelentPupil();
                        return tipeOfPupil;
                    }
                case 2:
                    {
                        tipeOfPupil = new GoodPupil();
                        return tipeOfPupil;
                    }
                default:
                    {
                        tipeOfPupil = new BadPupil();
                        return tipeOfPupil;
                    }
            }
        }

    }
}
