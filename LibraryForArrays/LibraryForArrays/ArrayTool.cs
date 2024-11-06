using System;
using System.Collections;
using System.Reflection;
using System.Threading.Channels;

namespace LibraryForArrays
{
    public class ArrayTool
    {
        static private Random random = new Random();

        /// <summary>
        /// Validation of length. 
        /// Value has to be bigger then 0 and it has to be a number.
        /// </summary>
        /// <returns></returns>
        public static int InputCorrectLength()
        {
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out int length) && length > 0)
                    return length;
                else
                    Console.Write("Try again: ");
            } while (true);
        }


        /// <summary>
        /// This method outputs to console all elements in the row and then breaks line.
        /// You can change distance between elements by second parameter.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="space"></param>
        public static void ShowArray(IEnumerable array, string space = "\t")
        {
            foreach (var element in array)
                Console.Write(element + space);
            Console.WriteLine();
        }
        /// <summary>
        /// This method outputs to console all elements of two-dimensional array (looks like matrix).
        /// You can change distance between elements by second parameter.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="space"></param>
        public static void ShowArray<T>(T[,] array, string space = "\t")
        {
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for(int column = 0; column < array.GetLength(1); column++)
                    Console.Write(array[row,column] + space);
                Console.WriteLine();
            }
        }


        /// <summary>
        /// Method fills your array with random values. You can choose maximum.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="max"></param>
        public static void FillArray(int[] array, int max = 10)
        {
            for (int index = 0; index < array.Length; index++)
                array[index] = random.Next(max);
        }
        /// <summary>
        /// Method fills your array with random values. You can choose maximum.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="max"></param>
        public static void FillArray(double[] array, int max = 10)
        {
            for (int index = 0; index < array.Length; index++)
                array[index] = random.Next(max);
        }
        /// <summary>
        /// Method fills your array with random values. You can choose maximum.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="max"></param>
        public static void FillArray(int[,] array, int max = 10)
        {
            for (int row = 0; row < array.GetLength(0); row++)
                for (int column = 0; column < array.GetLength(1); column++)
                    array[row, column] = random.Next(max);
        }
        /// <summary>
        /// Method fills your array with random values. You can choose maximum.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="max"></param>
        public static void FillArray(double[,] array, int max = 10)
        {
            for (int row = 0; row < array.GetLength(0); row++)
                for (int column = 0; column < array.GetLength(1); column++)
                    array[row, column] = random.Next(max);
        }
        /// <summary>
        /// Method fills your array with random values. You can choose minimum and maximum.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="max"></param>
        public static void FillArray(int[] array, int min, int max)
        {
            for (int index = 0; index < array.Length; index++)
                array[index] = random.Next(min, max);
        }
        /// <summary>
        /// Method fills your array with random values. You can choose minimum and maximum.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="max"></param>
        public static void FillArray(double[] array, int min, int max)
        {
            for (int index = 0;index < array.Length; index++)
                array[index] = random.Next(min, max);
        }
        /// <summary>
        /// Method fills your array with random values. You can choose minimum and maximum.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="max"></param>
        public static void FillArray(int[,] array, int min, int max)
        {
            for (int row = 0; row < array.GetLength(0); row++)
                for(int column = 0; column < array.GetLength(1); column++)
                    array[row,column] = random.Next(min, max);
        }
        /// <summary>
        /// Method fills your array with random values. You can choose minimum and maximum.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="max"></param>
        public static void FillArray(double[,] array, int min, int max)
        {
            for (int row = 0; row < array.GetLength(0); row++)
                for (int column = 0; column < array.GetLength(1); column++)
                    array[row, column] = random.Next(min, max);
        }
                

        /// <summary>
        /// Method Inputs values from consol and checks them for validation. 
        /// If there something wrong, program'll be asking until you put correct value. 
        /// </summary>
        /// <param name="array"></param>
        public static void InputArray(int[] array)
        {
            for (int index = 0, value; index < array.Length; index++)
            {
                Console.Write("Input element by index [" + index + "]: ");
                while (!Int32.TryParse(Console.ReadLine(), out value));
                array[index] = value;
            }
        }
        /// <summary>
        /// Method Inputs values from consol and checks them for validation. 
        /// If there something wrong, program'll be asking until you put correct value. 
        /// </summary>
        /// <param name="array"></param>
        public static void InputArray(double[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                double value;
                Console.Write("Input element by index [" + index + "]: ");
                while (!Double.TryParse(Console.ReadLine(), out value)) ;
                array[index] = value;
            }
        }
        /// <summary>
        /// Method Inputs values from consol and checks them for validation. 
        /// If there something wrong, program'll be asking until you put correct value. 
        /// </summary>
        /// <param name="array"></param>
        public static void InputArray(int[,] array)
        {
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for(int column = 0, value; column < array.GetLength(1); column++)
                {
                    Console.Write("Input element by index [" + row + "][" + column + "]: ");
                    while (!Int32.TryParse(Console.ReadLine(), out value)) ;
                    array[row,column] = value;
                }
            }
        }
        /// <summary>
        /// Method Inputs values from consol and checks them for validation. 
        /// If there something wrong, program'll be asking until you put correct value. 
        /// </summary>
        /// <param name="array"></param>
        public static void InputArray(double[,] array)
        {
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    double value;
                    Console.Write("Input element by index [" + row + "][" + column + "]: ");
                    while (!Double.TryParse(Console.ReadLine(), out value)) ;
                    array[row, column] = value;
                }
            }
        }

      
        /// <summary>
        /// Method creates new bigger array, inserts new element by index and rewrite rest values.
        /// Finally, it changes ref of your array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="index"></param>
        /// <param name="newElement"></param>
        public static void AddElementInArray<T>(ref T[] array, int index, T newElement)
        {
            T[] anotherArr = new T[array.Length + 1];

            for (int i = 0; i < index; i++)
                anotherArr[i] = array[i];

            anotherArr[index] = newElement;

            for (int i = index + 1; i < anotherArr.Length; i++)
                anotherArr[i] = array[i - 1];

            array = anotherArr;
        }
        /// <summary>
        /// Method creates new smaller array and rewrite values without element by index.
        /// Finally, it changes ref of your array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="index"></param>
        public static void RemoveElementFromArray<T>(ref T[] array, int index)
        {
            T[] anotherArr = new T[array.Length - 1];

            for (int i = 0; i < index; i++)
                anotherArr[i] = array[i];

            for (int i = index; i < anotherArr.Length; i++)
                anotherArr[i] = array[i + 1];

            array = anotherArr;
        }


        /// <summary>
        /// Returns index of given value. 
        /// If there no element in the array, method returns -1.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                int middle = (left + right) / 2;
                if (target < array[middle])
                    right = middle - 1;
                else if (target > array[middle])
                    left = middle + 1;
                else
                    return middle;
            }
            return -1;
        }


        /// <summary>
        /// Method sorts array from min to max by default.
        /// If you make second parameter "true", method'll sort array from max to min.
        /// </summary>
        /// <param name="array"></param>
        public static void BubbleSort(int[] array, bool descending = false)
        {
            bool changed;
            if (descending)
            {
                do
                {
                    changed = false;
                    for (int index = array.Length - 1; index > 0; index--)
                        if (array[index] > array[index - 1])
                        {
                            Swap(array, index, index - 1);
                            changed = true;
                        }

                } while (changed);
            }
            else
            {
                do
                {
                    changed = false;
                    for (int index = 0; index < array.Length - 1; index++)
                        if (array[index] > array[index + 1])
                        {
                            Swap(array, index, index + 1);
                            changed = true;
                        }

                } while (changed);
            }
        }
        /// <summary>
        /// Method sorts array from min to max by default.
        /// If you make second parameter "true", method'll sort array from max to min.
        /// </summary>
        /// <param name="array"></param>
        public static void BubbleSort(double[] array, bool descending = false)
        {
            bool changed;
            if (descending)
            {
                do
                {
                    changed = false;
                    for (int index = array.Length - 1; index > 0; index--)
                        if (array[index] > array[index - 1])
                            Swap(array, index, index - 1);

                } while (changed);
            }
            else
            {
                do
                {
                    changed = false;
                    for (int index = 0; index < array.Length - 1; index++)
                        if (array[index] > array[index + 1])
                            Swap(array, index, index + 1);

                } while (changed);
            }
        }
        private static void Swap<T>(T[] array, int indexOfFirstElement, int indexOfSecondElement)
        {
            T box = array[indexOfFirstElement];
            array[indexOfFirstElement] = array[indexOfSecondElement];
            array[indexOfSecondElement] = box;
        }

        public static void MergeSort(int[] arr, int left, int right)
        {
            if (left >= right) return;
            int middle = left + (right - left) / 2;
            MergeSort(arr, left, middle);
            MergeSort(arr, middle + 1, right);
            Merge(arr, left, middle, right);
        }
        private static void Merge(int[] arr, int left, int middle, int right)
        {
            int leftSideLength = middle - left + 1;
            int rightSideLength = right - middle;

            int[] leftArray = new int[leftSideLength];
            int[] rightArray = new int[rightSideLength];

            for (int i = 0; i < leftSideLength; i++)
                leftArray[i] = arr[left + i];

            for (int i = 0; i < rightSideLength; i++)
                rightArray[i] = arr[middle + 1 + i];

            int indexOfLeftArr = 0, indexOfRightArr = 0, indexOfMainArr = left;

            while (indexOfLeftArr < leftSideLength && indexOfRightArr < rightSideLength)
            {
                if (leftArray[indexOfLeftArr] <= rightArray[indexOfRightArr])
                {
                    arr[indexOfMainArr] = leftArray[indexOfLeftArr];
                    indexOfLeftArr++;
                }
                else
                {
                    arr[indexOfMainArr] = rightArray[indexOfRightArr];
                    indexOfRightArr++;
                }
                indexOfMainArr++;
            }

            while (indexOfLeftArr < leftSideLength)
            {
                arr[indexOfMainArr] = leftArray[indexOfLeftArr];
                indexOfLeftArr++;
                indexOfMainArr++;
            }
            while (indexOfRightArr < rightSideLength)
            {
                arr[indexOfMainArr] = rightArray[indexOfRightArr];
                indexOfRightArr++;
                indexOfMainArr++;
            }
        }
    }
}