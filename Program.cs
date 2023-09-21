string[] CreateArray(int length)
{
    string[] array = new string [length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

bool IsThreeElement (string array)
{
    int count = int.Parse(array.Length.ToString());
    if (count > 3) return false;
    return true;
}

int length = 5;
string[] arr = CreateArray(length);
Console.WriteLine(IsThreeElement("tre"));