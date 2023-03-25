Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array1 = new string[size];

for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива");
    string result = Console.ReadLine();
    array1[i] = result;
}
Console.WriteLine();
Console.Write("Введенный массив: [");
Console.Write(string.Join(",", array1));
Console.Write("]");

int count = 0;
int maxChar = 3;

for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= maxChar)
    {
        count++;
    }
}