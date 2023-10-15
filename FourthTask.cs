using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork05
{
    /// <summary>
    /// 4.	Реализовать несколько методов или классов с методами и вызвать один метод из другого. 
    ///     В вызываемом методе сгенерировать исключение и «поднять» его в вызывающий метод.
    /// </summary>
    public class Calculator
    {
        public int Delete(int delimoe, int delitel)
        {
            if (delitel == 0)
            {
                throw new DivideByZeroException("Попытка деления на ноль");
            }
            return delimoe / delitel;
        }

        public void RunCalculation()
        {
            int dividend = 10;
            int divisor = 0;

            try
            {
                int result = Delete(dividend, divisor);
                Console.WriteLine("Результат деления: " + result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Произошла ошибка: " + e.Message);
            }
        }
    }
}

