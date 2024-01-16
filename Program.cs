using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1p1
{
    public class Program
    {
        //В одномерном массиве, состоящем из N целочисленных элементов, вычислить:
        //1) произведение элементов массива с четными номерами
        //2) сумму элементов массива, расположенных между первым и последним нулевыми элементами.
        //Преобразовать массив таким образом, чтобы сначала располагались все положительные элементы,
        //а потом — все отрицательные(элементы, равные нулю, считать положительными).
        static void Main(string[] args)
        {
            double[] Mas;
            Console.WriteLine("Введите число элементов массива: ");
            int N = int.Parse(Console.ReadLine());
            if (N > 0)
            {
                Mas = new double[N];
                Part1.InputArray(ref Mas);
                Console.WriteLine($"Произведение элементов массива с четными номерами: {Part1.product_of_even(ref Mas)}");
                int first = Part1.FindFirstZero(ref Mas);
                int last = Part1.FindLastZero(ref Mas);
                if (first==-1)
                {
                    Console.WriteLine("В массиве нет нулевых элементов!");
                }
                else
                if (last == first)
                {
                    Console.WriteLine("В массиве один нулевой элемент!");
                }
                else
                if (last == first + 1)
                {
                    Console.WriteLine("В массиве нет элементов между нулевыми элементами!");
                }
                else
                {
                    Console.WriteLine($"Сумма элементов, расположенных между первым и последним нулевыми элементами: {Part1.Sum_of_elements(ref Mas,first+1,last-1)}");
                }
                Part1.ChangeArray(ref Mas);
                Part1.DisplayArray(ref Mas);
            }
            else
            {
                Console.WriteLine("Ошибка ввода числа элементов массива!");
            }
            Console.ReadLine();
        }
    }
}
