string[] CreateArray(int length)  // метод для заполнения массива строк
{
    string[] array = new string [length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i+1} элемент массива: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

bool IsThreeElement (string array)  // проверка строки. Удовлетворяет ли условиям?
{
    int count = int.Parse(array.Length.ToString());
    if (count > 3) return false;
    return true;
}

int Counter (string[] array) // считает количество строк, удовлетворяющих условиям. Для того
{                            // чтобы создать новый массив с необходимой размерностью
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (IsThreeElement(array[i])) counter++;
    }
    return counter;
}

string[] CopyArrayThree (string[] array, int size) // копирует необходимые элементы в новый массив
{
    string[] newArray = new string [size];
    int element = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (IsThreeElement(array[i]))
        {
            newArray[element] = array[i];
            element++;
        }
    }
    return newArray;
}

int length = 5;
string[] arr = CreateArray(length);
int size = Counter(arr);
string[] newArr = CopyArrayThree(arr, size); 
Console.WriteLine(string.Join("; ", newArr));