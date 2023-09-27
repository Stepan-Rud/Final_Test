string[] arrayFirst = new string[5] {"sunday", "munday", "sun", "help", "123" };
string[] arraySecond = new string[arrayFirst.Length];
PaddingWithThreeChar(arrayFirst, arraySecond);
PrintArray(arraySecond);
void PrintArray(string[] arr, string sep = " ")
{
  for (int i = 0; i < arr.Length; i++)
  {
    if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep}");
    else Console.Write($"{arr[i]}");
  }
}
void PaddingWithThreeChar(string[] arr, string[] newarr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
             newarr[count] = arr[i];
             count++;
        }
    }
}
