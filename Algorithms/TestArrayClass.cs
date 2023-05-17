namespace Algorithms
{
    public class TestArrayClass
    {
        // Объявления
        void MthArray() 
        {
            // Объявить массив из 5 элементов
            int[] array1 = new int[5];

            // Объявить и установить значения
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };
            int[] array3 = { 4, 45, 23, 1 };

            // Двумерный массив
            int[,] multiArray1 = new int[2, 3];
            int[,] mulriArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Объявить зубчатый массив
            int[][] jaggetArray = new int[6][];
            // установить значеня первого массива в структуре зубчатого массива
            jaggetArray[0] = new int[4] {1, 2, 3, 4 }; 
        }

        // Массивы как объекты
        public static int ArrayAsObjects()
        {
            // Array - абстрактный класс для всех массивов. Можно использовать свойста и другие члены этого класса ко всем массивам. Наример cвойство Length
            // Length - получить длинну массива
            int[] numbers = { 1, 2, 3, 4, 5 };
            int lengthOfNumbers = numbers.Length;

            return lengthOfNumbers;

        }
    }
}
