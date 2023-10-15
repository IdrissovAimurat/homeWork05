using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork05
{
    /// <summary>
    /// 3.	Реализовать несколько методов или классов с методами и вызвать один метод из другого. 
    ///     В вызываемом методе сгенерировать исключение и «поднять» его в вызывающий метод.
    /// </summary>
    public class ThirdTask
    {
        public static void ExampleMethod(int[] arr, int index)
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
