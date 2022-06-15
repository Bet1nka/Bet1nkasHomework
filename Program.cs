string[] startarray = { "Geek", "Brains", "--", "i", "love", "<3", "GB", "GeekBrains", "---", };
string[] CreateArray3symbols(string[] arr)
{
    string[] newarr = new string[arr.Length];
    for (int i = 0, j = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 3 || arr[i].Length == 3)
        {
            newarr[j] = arr[i];
            j++;
        }
    }
    return newarr;

}
string[] newarray = CreateArray3symbols(startarray);

void PrintArr(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
PrintArr(newarray);

/*
string[] Create(int size)
{
    string[] stringArray = new string[size];
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine(" input element of your arr: ");
        stringArray[i] = Console.ReadLine();
    }return stringArray;
}
Console.WriteLine("input size");
int s = Convert.ToInt32(Console.ReadLine());
string[] createyourarr = Create(s);
PrintArr(createyourarr);
Console.WriteLine();
PrintArr(CreateArray3symbols(createyourarr));
*/