/* Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

  int SumOfDigits(int numN)
  {
    int counter = Convert.ToString(numN).Length;
    //int advance = 0;
    //int result = 0;
    int sum = 0;
    int num = 0;
    for (int i = 0; i < counter; i++)
    {
        num = numN % 10;
        sum = sum + num;
        numN = numN / 10;
        
      /* advance = numN - numN % 10;
      result = result + (numN - advance);
      numN = numN / 10; */
    }
    return sum;
    // return result;
  }

int sumOfDig = SumOfDigits(numN);
Console.WriteLine("Сумма цифр в числе: " + sumOfDig);