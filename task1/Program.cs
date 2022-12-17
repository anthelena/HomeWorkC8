// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int M = Number("M");
int N = Number("N");
Console.Write($"Сумма натуральных элементов ");
Console.WriteLine($"от M = {M} до N = {N} равна {PrintSummer(M, N)}");

int PrintSummer(int M, int N) 
{
   if(M > N) 
   {
       return 0;
   }
   return M + PrintSummer(M + 1, N);
}

int Number(string name) 
{
    Console.Write($"Введите число {name}: ");
    return int.Parse(Console.ReadLine());
}

