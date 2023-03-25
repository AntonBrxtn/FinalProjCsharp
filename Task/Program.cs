Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array1 = new string[size];

for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива");
    string result = Console.ReadLine();
    array1[i] = result;
}