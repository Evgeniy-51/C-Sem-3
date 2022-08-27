Console.Clear();

Console.Write("Enter a number:  ");
int n = Int32.Parse(Console.ReadLine());

int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    arr[i] = (i + 1) * (i + 1) * (i + 1);
    // arr[i] = Int32.Parse(Math.Pow(3, 3));
}

Console.WriteLine(String.Join(", ", arr));
