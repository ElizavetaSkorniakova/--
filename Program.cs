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

void analyzedArray (string[] userArray)
{
    string[] analyzedUserArray = new string[userArray.Length];
    int j = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i].Length <= 3)
        {
            analyzedUserArray[j] = userArray[i];
            j++;
        }
    }
Console.Write("Обработанный массив: ");
for (int i = 0; i < analyzedUserArray.Length; i++)
    {
        Console.Write($"{analyzedUserArray[i]} ");
    }
Console.WriteLine();
}

int G = getUserData("Введите количество записей в массиве");
string[] UserArrayDisplay = EnterUserArray (G);
analyzedArray(UserArrayDisplay);
