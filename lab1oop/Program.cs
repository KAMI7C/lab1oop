// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите типы данных  int, float, double, bool, byte, sbyte, char, short, ushort, long, ulong, demical, uint, string");
            int int1 = Convert.ToInt32(Console.ReadLine());
            float float1 = Convert.ToSingle(Console.ReadLine());
            double doluble1 = Convert.ToDouble(Console.ReadLine());
            bool bool1 = Convert.ToBoolean(Console.ReadLine());
            byte byte1 = Convert.ToByte(Console.ReadLine());
            sbyte sb1 = Convert.ToSByte(Console.ReadLine());
            char ch1 = Convert.ToChar(Console.ReadLine());
            short sh1 = Convert.ToInt16(Console.ReadLine());
            ushort ush1 = Convert.ToUInt16(Console.ReadLine());
            long lg1 = Convert.ToInt16(Console.ReadLine());
            ulong ulg1 = Convert.ToUInt64(Console.ReadLine());
            decimal dec1 = Convert.ToDecimal(Console.ReadLine());
            uint uint1 = Convert.ToUInt32(Console.ReadLine());
            string str1 = Console.ReadLine();

            Console.WriteLine("int " + int1 + "float " + float1 + "double " + doluble1 + "bool "
                + bool1 + "byte " + byte1 + "sbyte " + sb1 + "char " + ch1 + "short " + sh1 + "ushort " + ush1 + "long " + lg1 + "ulong " + ulg1 + "decimal " + dec1 + "uint " + uint1 + "string " + str1);


            //Неявные преобразования
            int num = 2147483647;
            long bigNum1 = num;

            float floatValue1 = 123.45F;
            double doubleValue1 = floatValue1;

            char charValue1 = 'A';
            int intFromChar1 = charValue1;

            byte byteValue1 = 255;
            int intFromByte1 = byteValue1;

            ushort ushortValue1 = 65535;
            uint uintValue1 = ushortValue1;
            // есть ещё такой вариант long transToLongImp = a4;

            //явное приведение
            double doubleValue2 = 123.45;
            int intValue1 = (int)doubleValue2;

            long longValue2 = 123456789L;
            int intValue2 = (int)longValue2;

            float floatValue2 = 123.45F;
            int intValue3 = (int)floatValue2;

            int intValue4 = 255;
            byte byteValue2 = (byte)intValue4;

            double doubleValue4 = 123.45;
            float floatValue5 = (float)doubleValue4;


            //c

            // Упаковка
            int value = 228;
            object boxedValue = value; // Упаковка (boxing)
            Console.WriteLine("Упакованное значение: " + boxedValue);

            // Распаковка
            int unboxedValue = (int)boxedValue; // Распаковка (unboxing)
            Console.WriteLine("Распакованное значение: " + unboxedValue);


            //e
            float? a = null;
            Console.WriteLine(a);

            //f, d
            var Type = true;
            Console.WriteLine(Type.GetType());
            /*
            var myVariable = 10; // myVariable имеет тип int
            myVariable = "Hello";*/

            //2a

            string fr0 = "hello popa";
            string fr1 = "hello chop";
            string berserc = "I just want to be happy";

            bool equal12 = fr0.Equals(fr1);
            bool equal23 = fr1.Equals(berserc);
            bool length12 = fr0.Length == fr1.Length;
            bool length23 = fr1.Length == berserc.Length;
            Console.WriteLine("Результат сравнения строки " + fr0 + " и " + fr1 + " = " + equal12 + " И длинны " + length12);
            Console.WriteLine("Результат сравнения строки " + fr1 + " и " + berserc + " = " + equal23 + " И длинны " + length23);

            //2b

            // Создание строк
            string str13 = "Привет";
            string str23 = "мир";
            string str33 = "дружба жвачка";

            // 1. Сцепление строк
            string concatenated = str13 + " " + str23;
            Console.WriteLine($"Сцепление: {concatenated}");

            // 2. Копирование строки
            string copiedString = string.Copy(str13);
            /* или просто string str1 = "Hello, World!";
            string copiedString = str1;
            Console.WriteLine($"Копирование: {copiedString}");*/

            // 3. Выделение подстроки
            string substring = str33.Substring(0, 6);
            Console.WriteLine($"Подстрока: {substring}");

            // 4. Разделение строки на слова
            string[] words = str33.Split(' '); // Разделение по пробелу
            Console.WriteLine("Разделение на слова:");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            // 5. Вставка подстроки в заданную позицию
            string insertedString = str33.Insert(2, " и "); // Вставка " и " на позицию 2
            Console.WriteLine($"Вставка: {insertedString}");

            // 6. Удаление заданной подстроки
            string removedSubstring = str33.Replace("дружба", " "); // Удаление слова "язык"
            Console.WriteLine($"Удаление подстроки: {removedSubstring}");
            /*или string result = str.Remove(10, 6); */

            // b. Интерполирование строк
            string name = "мама";
            int age = 30;
            string interpolatedString = $"я люблю {name}, ей {age} лет.";
            Console.WriteLine(interpolatedString);


            //c
            // Создание пустой и null строки
            string emptyString = ""; // Пустая строка
            string nullString = null; // Null строка

            // Использование метода IsNullOrEmpty
            Console.WriteLine($"Is emptyString null or empty? {string.IsNullOrEmpty(emptyString)}"); // True
            Console.WriteLine($"Is nullString null or empty? {string.IsNullOrEmpty(nullString)}"); // True

            // Примеры действий с пустой и null строками
            if (!string.IsNullOrEmpty(emptyString))
            {
                Console.WriteLine($"Length of emptyString: {emptyString.Length}"); // Не выполнится
            }

            if (!string.IsNullOrEmpty(nullString))
            {
                Console.WriteLine($"Length of nullString: {nullString.Length}"); // Не выполнится
            }

            // Пример с использованием пустой строки
            string concatenated2 = emptyString + "Hello"; // Присоединение к пустой строке
            Console.WriteLine($"Concatenated result: '{concatenated2}'"); // "Hello"

            //d
            // Создание строки с использованием StringBuilder
            StringBuilder sb = new StringBuilder("Привет, мир!");

            sb.Remove(8, 4);
            Console.WriteLine($"После удаления: {sb}");

            sb.Insert(0, "Здравствуй, ");
            sb.Append(" Как дела?");

            Console.WriteLine($"После вставки и добавления: {sb}");

            //МАССИВЫ
            Array();

            //кортеджи
            Corteg();

            //6
            int[] numbers = { 1, 22, 3, 7, 7 };
            string text = "IwontPop";
            var result = Process(numbers, text);

            Console.WriteLine($"Макс: {result.Max}, Мин: {result.Min}, Сумма: {result.Sum}, Первая буква: {result.FirstLetter}");

        }
        static void Array()
        {
            //a
            Console.Write("Введите количество строк: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, columns];

            Console.WriteLine("Введите элементы массива (по одному через пробел):");
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Строка {i + 1}:");
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }

            Console.WriteLine("Матрица:");
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Console.Write($"{matrix[r, c],4} ");
                }
                Console.WriteLine();
            }
            //b
            string[] strar = { "Какиш", "Кукиш", "Чернозём" };
            Console.WriteLine("содержисое массива");
            foreach (string minstr in strar)
            {
                Console.WriteLine(minstr);
            }
            Console.WriteLine($"длина массива {strar.Length}");
            Console.Write("Введите позицию элемента для изменения (от 0 до {0}): ", strar.Length - 1);
            int index = int.Parse(Console.ReadLine());


            if (index >= 0 && index < strar.Length)
            {
                Console.Write("Введите новое значение: ");
                string newValue = Console.ReadLine();
                strar[index] = newValue;


                Console.WriteLine("Обновленное содержимое массива:");
                foreach (var str in strar)
                {
                    Console.WriteLine(str);
                }


            }
            //c
            double[][] jaggedArr = new double[3][];
            jaggedArr[0] = new double[2];
            jaggedArr[1] = new double[3];
            jaggedArr[2] = new double[4];

            Console.WriteLine("Заполните ступенчатый массив: ");
            for (int i = 0; i < 2; i++)
            {
                jaggedArr[0][i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                jaggedArr[1][i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                jaggedArr[2][i] = Convert.ToDouble(Console.ReadLine());
            }



            foreach (double[] row in jaggedArr)
            {
                foreach (double number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }

            //d
            var message = "Привет, мир!";
            // Неявно типизированный двумерный массив
            var twoDimensionalArray = new[,]
            {
            { 1.1, 2.2, 3.3 },
            { 4.4, 5.5, 6.6 },
            { 7.7, 8.8, 9.9 }
        };

        }
        static void Corteg()
        //a-b
        {
            var Tuple = (Id: 1, Name: "Djoske", Initial: 'S', City: "StavlyDyshyMAtery", Population: 1234567890UL);

            Console.WriteLine("Кортеж целиком:");
            Console.WriteLine(Tuple);

            Console.WriteLine("\nВыборочные элементы:");
            Console.WriteLine($"1 элемент: {Tuple.Id}");
            Console.WriteLine($"3 элемент: {Tuple.Initial}");
            Console.WriteLine($"4 элемент: {Tuple.City}");

            //c
            // c. Распаковка кортежа в переменные
            var tupp = (1, "Hello", 3.14, "lol");
            var (i, str, c, str2) = tupp;
            Console.WriteLine($"items: {tupp} {str}");
            (int i2, _, _, string ul2) = tupp;
            Console.WriteLine($"items: {tupp}");

            //d
            var t1 = (3, 2, 4, 5, 6, 3, 5);
            var t2 = (3, 2, 4, 5, 5, 3, 5);
            if (t1 == t2)
            {
                Console.WriteLine("true");
            }
            else
            { Console.WriteLine("false"); }
        }
        //6


        static (int Max, int Min, int Sum, char FirstLetter) Process(int[] nums, string str)
        {

            int max = nums[0];
            int min = nums[0];
            int sum = 0;

            foreach (var num in nums)
            {
                if (num > max) max = num;
                if (num < min) min = num;
                sum += num;
            }

            // Получаем первую букву строки
            char firstLetter = str[0];

            return (max, min, sum, firstLetter);
        }
        //7
        static void CheckedFunction()
        {
            try
            {
                // Блок checked
                checked
                {
                    int maxInt = int.MaxValue;
                    Console.WriteLine($"В checked: {maxInt}");
                    int result = maxInt + 1;
                    Console.WriteLine($"Результат: {result}");
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Ошибка в checked: {e.Message}");
            }
        }

        static void UncheckedFunction()
        {

            unchecked
            {
                int maxInt = int.MaxValue;
                Console.WriteLine($"В unchecked: {maxInt}");
                int result = maxInt + 1;
                Console.WriteLine($"Результат: {result}");
            }
        }
    }

}

