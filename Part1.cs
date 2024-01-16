using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Lab1p1
{
    public class Part1
    {
        //1) произведение элементов массива с четными номерами
        public static double product_of_even(ref double[] Arr)
        {
            if (Arr.Count() > 1) {
                double res = 1;
                for (int i = 1; i < Arr.Count(); i = i + 2)
                {
                    res *= Arr[i];
                }
                return res;
            }
            else
            {
                return 0;
            }
        }
        // сумму элементов массива, расположенных от begin до end
        public static double Sum_of_elements(ref double[] Arr,int begin,int end)
        {
            double res = 0;
            for (int i = begin; i <= end; i++)
            {
                res += Arr[i];
            }
            return res;
        }
        // Найдём индекс первого нулевого элемента
        public static int FindFirstZero(ref double[] Arr)
        {
            for (int i = 0; i < Arr.Count(); i++)
            {
                if (Arr[i] == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        // Найдём индекс последнего нулевого элемента
        public static int FindLastZero(ref double[] Arr)
        {
            if (Arr.Count() >0)
            {
                for (int i = Arr.Count() - 1; i >= 0; i--)
                {
                    if (Arr[i] == 0)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        //Преобразовать массив таким образом, чтобы сначала располагались все положительные элементы,
        //а потом — все отрицательные(элементы, равные нулю, считать положительными).
        public static void ChangeArray(ref double[] Arr)
        {
            for (int i = 0; i < Arr.Count() - 1; i++)
            {
                if (Arr[i] < 0)
                {
                    int beg = i + 1;
                    while (beg < Arr.Count() && Arr[beg] < 0) beg++;
                    if (beg < Arr.Count() && Arr[beg] > 0)
                    {
                        double tmp = Arr[i];
                        Arr[i] = Arr[beg];
                        Arr[beg] = tmp;
                    }
                }
            }
        }
        //Ввод массива
        public static bool InputArray(ref double[] Arr)
        {
            try
            {
                Console.WriteLine("Введите элементы массива: ");
                for (int i = 0; i < Arr.Count(); i++)
                {
                    Arr[i] = double.Parse(Console.ReadLine());
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Вывод массива
        public static void DisplayArray(ref double[] Arr)
        {
            Console.Write("Массив: ");
            foreach (double item in Arr)
            {
                Console.Write(item.ToString()+" ");
            }
            Console.Write("\n");
        }

    }
}
