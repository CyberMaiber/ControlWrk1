void ArrayPrint(string[] ourArray, string caption) //Печать массива
{
    Console.WriteLine(caption + ":");
    for (int i = 0; i < ourArray.Length; i++) Console.Write($"{ourArray[i]} \t");
}

void FeelArray(string[] ourArray) //Заполнение массива
{
    Console.WriteLine($"Введите {ourArray.Length} строк для заполнения исходного массива: ");
    for (int i = 0; i < ourArray.Length; i++)
    {
        ourArray[i] = Console.ReadLine();
    }
}

int CountingInArray(string[] ourArray, int param)
{
    int result = 0;
    for (int i = 0; i < ourArray.Length; i++)
    {
        if (ourArray[i].Length <= param) result++;
    }
    return result;
}
int condition = 3; //условие попадания в результирующий массив
Console.Write("Введите число элементов массива: ");
int elemCount = Convert.ToInt32(Console.ReadLine());
string[] initMass = new string[elemCount]; //создание исходного массива
FeelArray(initMass); //заполнение массива
int count = CountingInArray(initMass, condition); //Переменная для хранения количества элементов, соответствующих условию
string[] resultMass = new string[count]; //создание результирующего массива
count = 0;

for (int i = 0; i < elemCount; i++)
{
    if (initMass[i].Length <= condition)
    {
        resultMass[count] = initMass[i];
        count++;
    }
}

ArrayPrint(resultMass, "Результирующий массив"); //печать результирующего массива