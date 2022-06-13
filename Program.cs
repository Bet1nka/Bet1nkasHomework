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