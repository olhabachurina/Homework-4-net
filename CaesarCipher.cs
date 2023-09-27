using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_net
{
    public class CaesarCipher
    {
        public static string Encrypt(string text, int shift)//метод шифрования екста шифром Цезаря
        {
            char[] result = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                if (char.IsLetter(ch))// проверяем символ,является буквой
                {
                    char offset = char.IsUpper(ch) ? 'A' : 'a';//определение смещения для буквы в зависимости от регистра
                    result[i] = (char)(((ch + shift - offset) % 26 + 26) % 26 + offset);//шифруем
                }
                else
                {
                    result[i] = ch;// если символ не буква,оставляем без изменеий
                }
            }

            return new string(result);
        }
           public static string Decrypt(string text, int shift)//Метод для расшифровки текста, используя шифр Цезаря
        {
               
                return Encrypt(text, -shift);// Расшифровка ,отрицательное смещение
        }

        
        }
    }

