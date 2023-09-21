string[] CreateArray(int length)
{
    string[] array = new string [length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

int length = 5;
string[] arr = CreateArray(length);
Console.WriteLine(string.Join("; ", arr));