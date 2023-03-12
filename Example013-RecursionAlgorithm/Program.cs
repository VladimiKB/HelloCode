// ------------------------------ Вывод "слово" в точке двухмерного массива

//string[,] table = new string[2, 5];
// - String.Empty
// - table [0,0] table [0,1] table [0,2] table [0,4]
// - table [1,0] table [1,1] table [1,2] table [1,4]

// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

// --------------------------------------------------  Вывод числа в точке двухмерного массива

// void PrintArrey(int[,] matr)
// {
//     for (int i = 0; i < 3; i++)
//     // - i < matr. GetLength(0); "универсальный способ записать выражение i < 3;", где (0) обозначает что это строки.
//     {
//         for (int j = 0; j < 4; j++)
//         // - j < matr. GetLength(1); "универсальный способ записать выражение j < 3;", где (1) обозначает что это столбцы.
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// ------------------------------------- Вывод двухмерного массива в виде таблицы и рандомное заполнение в указаном диапазоне

// void FillArrey(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// int[,] matrix = new int[3, 4];
// PrintArrey(matrix);
// FillArrey(matrix);
// Console.WriteLine();
// PrintArrey(matrix);

// ----------------------------------------------------------- Закрашивание области рисунка

// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             // Console.Write($"{image[i, j]} ");
//             if (image[i, j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }

// void FillImage(int row, int col)
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, cot);
//         FillImage(row, col + 1);
//     }
// }

// PrintImage(pic); // - нет кода картинки ! поэтому не работает
// FillImage(13, 13);
// PrintImage(pic);

// -------------------------------------- Расчет факториала

// double Factorial(int n) // Вместо int -> double перед Factorial , позволит хранить больший объем данных
// {
//     //  1! = 1 - комментарий
//     //  0! = 1 - комментарий
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; 1 < 10; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

// ---------------------------------------- Числа Фибоначчи {f(n) = f(n-1) + f(n-2)}

// Комментарии
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

// double Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci (i)}"); // Можно написать - Console.WriteLine(Fibonacci(i));
// }

