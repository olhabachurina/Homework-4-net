using System;

namespace Homework_4_net
{
    class Program
    {
        
        static void Main()
        {
            Console.Write("Exercise 3 ");
            //Пользователь вводит символ с клавишами. Необходимо зашифровать эту строчку, используя шифр Цезаря.
            //Помимо механизма шифрования, используйте механизм расшифровки.
            Console.Write("Enter the encryption string: ");
            string inputText = Console.ReadLine();

            Console.Write("Enter the offset for the Caesar cipher (integer): ");
            int shiftValue = int.Parse(Console.ReadLine());

           
            string encryptedText = CaesarCipher.Encrypt(inputText, shiftValue);// Шифрование 
            string decryptedText = CaesarCipher.Decrypt(encryptedText, shiftValue);//расшифровка

            
            Console.WriteLine($"\nCiphertext: {encryptedText}");
            Console.WriteLine($"РDecrypted text: {decryptedText}");
            Console.Write("Exercise 5 ");
            //Пользователь с клавиатуры вводит в строку арифметическое выражение. Приложение должно подсчитать его результат.
            //Необходимо соблюдать только две операции: + и –.
            Console.Write("Enter an arithmetic expression(+ and -): ");
            string inputExpression = Console.ReadLine();

            int result = Calculator.CalculateExpression(inputExpression);

            Console.WriteLine($"Result: {result}");
        }
    }
}