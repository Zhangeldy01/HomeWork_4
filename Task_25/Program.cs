/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Write("Введите число A: ");
  int a = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int b = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int a, int b)
{
  int result = a;
  for(int i=1; i < b; i++)
  {
    result = result * a;
  } 
     // int result = Math.Pow(a, b);
     return result;
}
int exponentiation = Exponentiation(a, b);
Console.WriteLine($"A в степени B равно: {exponentiation}");


