using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork05
{
    /// <summary>
    /// 2.	Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы. 
    ///     После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.
    /// </summary>
    public class SecondTask
    {
        public static void ArrayTCF(int[] arr, int index)
        {
            try
            {
                if (index < 0 || index > arr.Length)
                {
                    throw new IndexOutOfRangeException("Индекс находится за пределами массива");
                }
                int element = arr[index];
                Console.WriteLine("Элемент массива: {0}", element);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Произошла ошибка: " + e.Message);
            }
        }
    }
}
