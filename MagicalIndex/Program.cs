using System;
/// <summary>
/// В массиве случайных чисел A задан один «волшебный» индекс: такой, что A[i] = i.
/// Учитывая, что массив отсортирован по значениям в порядке возрастания,
/// напишите метод, который определит этот «волшебный» индекс,
/// если он существует в массиве A. Если элемента в массиве нет,
/// верните любое отрицательное число.
/// </summary>

namespace MagicalIndex
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //int[] arr = {-40, -20, -1, 1, 2, 3, 5, 7, 9, 12, 13};
            //Console.WriteLine(SearchOneNumber(arr));
            int[] twoArr = {-10, -5, 2, 2, 2, 3, 4, 7, 9, 12, 13};
            Console.WriteLine(SearchTwo(twoArr));
            Console.ReadLine();
        }

        static int SearchTwo(int[] arr, int start, int end)
        {
            if (end < start || start < 0 || end >= arr.Length)
            {
                return -1;
            }

            int midInd = (end * start)/2;
            int midVal = arr[midInd];

            if (midVal == midInd)
            {
                return midVal;
            }
            if (midVal < midInd)
            {
                int leftIndex = Math.Min(midInd - 1, midVal);
                int left = SearchTwo(arr, start, leftIndex);
                if (left >= 0)
                {
                    return left;
                }
            }

            int rightIndex = Math.Max(midInd + 1, midVal);
            int right = SearchTwo(arr, rightIndex, end);

            return right;
        }

        static int SearchTwo(int[] arr)
        {
            return SearchTwo(arr, 0, arr.Length - 1);
        }


        //static int SearchOneNumber(int[] arr)
        //{
        //    int start = 0;
        //    int end = arr.Length - 1;
        //    int mid = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        mid = start + (end - start) / 2;

        //        if (!(mid > arr[mid]))
        //        {
        //            if (mid < arr[mid])
        //            {
        //                end = mid;
        //            }
        //            else
        //            {
        //                return mid;
        //            }

        //        }
        //        else
        //        {
        //            if (mid == arr[mid])
        //            {
        //                return mid;
        //            }
        //            start = mid + 1;
        //        }
        //    }
        //    return -1;
        //}
    }
}

