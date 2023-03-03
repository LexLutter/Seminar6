Console.Write($"Введите значенияпеременных для решения уравнения: \n");
double[] array = new double[4];
for (int i = 0; i < 4; i++)
{
    if (i == 0) Console.Write($"b1 = ");
    if (i == 1) Console.Write($"k1 = ");
    if (i == 2) Console.Write($"b2 = ");
    if (i == 3) Console.Write($"k2 = ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Массив: [ {String.Join(", ", array)} ]");

double x = (array[2] - array[0]) / (array[1] - array[3]);
double y = array[1] * x + array[0];
Console.WriteLine($"x равен {x}. y равен {y}. ");
