int firstNumber = 0;
int secondNumber = 1;
int result = 0;
for (int i = 3; i < 10; i++)
{
    result = firstNumber+secondNumber;
    firstNumber=secondNumber;
    secondNumber=result;
    System.Console.Write($"{result} ");
}


//  Решение --2
// int number = 8;

// int firstElement = 0;

// int secondElement = 1;
// Console.Write(firstElement + "\t" + secondElement + "\t"); // "\t" - Tab - табуляция
// for (int i = 3; i < number; i++)
// {
// int nextElement = firstElement + secondElement;
// Console.Write(nextElement + "\t");
// firstElement = secondElement;
// secondElement = nextElement;
// }