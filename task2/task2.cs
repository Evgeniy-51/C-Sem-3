// Программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

int[] CreateVector(string name)
{
    int[] arr = new int[3];
    for (int i = 0; i < 3; i++)
    {
        Console.Write(string.Concat("Введите ", i + 1, " координату вектора ", name, ":  "));
        arr[i] = Int32.Parse(Console.ReadLine());
    }
    return arr;
}

int[] a = CreateVector("A");
int[] b = CreateVector("B");
double Len = Math.Sqrt(Math.Pow((b[0] - a[0]), 2) + Math.Pow((b[1] - a[1]), 2) + Math.Pow((b[2] - a[2]), 2));

Console.Write(Math.Round(Len, 2));




