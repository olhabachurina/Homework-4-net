using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Calculator
{
    public static int CalculateExpression(string expression)
    {                                                       
        int result = 0;//результат инициализируем нулем
        int sign = 1;//знак как положательный инициализируем

        foreach (char c in expression)//проходим по каждому символу в введенном выражении
        {
            if (char.IsDigit(c))//если символ-цыфра,доьавляем к резльтату
            {
                result += (c - '0') * sign;
            }
            else if (c == '+')// Если символ - '+', обновляем знак на положительный.
            {
                sign = 1;
            }
            else if (c == '-')// Если символ - '-', обновляем знак на отрицательный.
            {
                sign = -1;
            }
        }

        return result;
        
    }
}
