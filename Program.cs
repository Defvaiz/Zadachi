using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачи1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadacha2 charPrinter = new Zadacha2();

            charPrinter.SetSymbols('A', 'Z');

            charPrinter.PrintCharactersInRange();

            //SymbolClass mySymbol = new SymbolClass();

            //mySymbol.SetSymbol('A');
            //mySymbol.DisplayInfo();

           // mySymbol.SetSymbol('B');
           // mySymbol.DisplayInfo();

         //   int[] intArray = GenerateArray(2, 4);
           // char[] charArray = GenerateArray('B', 'D');
            

            // string.Join используется для конкатенации элементов массива с помощью запятых
            // и пробелов в качестве разделителя. Результатом будет строка, представляющая элементы массива,
            // разделенные запятыми и пробелами. Это удобно для наглядного отображения содержимого массива при выводе на консоль.

            //Console.WriteLine($"Массив из целых чисел: " + string.Join("| ", intArray));
            //Console.WriteLine($"Массив из символов " + string.Join("| ", charArray));


            Console.ReadKey();  
        }

        class Zadacha2
        {
            private char startSymbol;
            private char endSymbol;

            public void SetSymbols(char start, char end)
            {
                startSymbol = start;
                endSymbol = end;
            }

            public void PrintCharactersInRange()
            {
                if (startSymbol <= endSymbol)
                {
                    for (char currentSymbol = startSymbol; currentSymbol <= endSymbol; currentSymbol++)
                    {
                        Console.Write(currentSymbol + " ");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }
                Console.WriteLine();
            }
        }

        //Zadacha 1
        class SymbolClass
        {
            private char symbol;

            public void SetSymbol(char newSymbol)
            {
                symbol = newSymbol;
            }
            public int GetSymbolCode()
            {
                return symbol;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Символ: {symbol}, код: {GetSymbolCode()}");
            }
        }


        //Задача 8

        static int[] GenerateArray(int start, int end)
        {
            int length = end - start + 1;
            int[] resultArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                resultArray[i] = start + i;
            }
            return resultArray;
        }
        static char[] GenerateArray(char start, char end)
        {
            int length = end -start + 1;
            char[] resultArray = new char[length];

            for (int i=0; i < length; i++)
            {
                resultArray[i] = (char)(start + i);
            }
            return resultArray;
        }

        //Задача 7
        static void Swap(char[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length / 2; i++)
            {
                char c = array[i];
                array[i] = array[length - 1 - i];
                array[length - 1 - i] = c;
            }
        }

        //Задача 5
        static int CalculateAverage(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }
            int sum = 0;

            foreach (int num in array)
            {
                sum += num;
            }
            return sum / array.Length;
        }

        //Задача 4
        static int[] GetCharCode(char[] charArray)
        {
            int[] resultArray = new int[charArray.Length];
            for ( int i = 0; i < charArray.Length; i++)
            {
                resultArray[i] = charArray[i];
            }
            return resultArray;
        }

        //Задача 3
        static int[] TakeElements(int[] array, int numberOfElements)
        {
            // Проверка, если количество элементов больше длины массива
            if (numberOfElements >= array.Length)
            {
                // Создание копии исходного массива и возвращение ссылки на копию
                int[] newArray = new int[array.Length];
                Array.Copy(array, newArray, array.Length);
                return newArray;
            }
            // Создание нового массива с указанным количеством элементов
            int[] resultArray = new int[numberOfElements];
            Array.Copy(array, resultArray, numberOfElements);
            return resultArray;
        }

        //Задача 2
        static int SumOfSquaresWithoutRecursion(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
            }
            return sum;
        }
        static int SumOfSquaresWithRecursion(int n)
        {
            if (n==1)
            {
                return 1;
            }
            return n * n + SumOfSquaresWithRecursion(n - 1);
        }

        //Задача 1
        static int DoubleFactorialWithoutRecursion(int n)
        {
            int result = 1;
            for (int i = n; i > 0; i -= 2)
            {
                result *= i;
            }
            return result;
        }
        static int DoubleFactorialWithRecursion(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * DoubleFactorialWithRecursion(n - 2);
        }
    }
}
