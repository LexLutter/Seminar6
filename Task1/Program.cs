int maxM = 8;
Console.Write($"Введите {maxM} чисел: \n");
int result = 0;
int[] array = new int[maxM];
for (int i = 0; i < maxM; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0) result++;
}
Console.WriteLine($"Массив: [ {String.Join(", ", array)} ]");
Console.WriteLine($"Пользователь  ввел {result} чисел больше 0.");