int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

string[] EnterUserArray (int arrayLength) // функция ввода записей в массив пользователем
{
string[] userArray = new string[arrayLength];
int i = 0;
 while (i < arrayLength)
  {
  Console.WriteLine("Введите запись");
  userArray[i] = Console.ReadLine();
  i++;
  }
 return userArray;
}

string[] analyzedUserArray (string[] userArray)
{
   int GreaterThan0Counter = 0;
  for ( int i = 0; i < userArray.Length;  i++ )
  {
    if (userArray[i] > 0) GreaterThan0Counter++;
  }
  Console.WriteLine();
  Console.WriteLine("количество введеных чисел больше 0 = " + GreaterThan0Counter);
  return GreaterThan0Counter;
}

int G = getUserData("Введите количество записей в массиве");
string[] arrayDisplayG = EnterUserArray (G);
