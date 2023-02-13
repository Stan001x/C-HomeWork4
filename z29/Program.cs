Console.Clear();

Console.WriteLine("Введите количество элементов массива: ");

int n = Convert.ToInt32(Console.ReadLine());

double[] arr = new double[n];

int begin = 0, end = 10;

for (int i = 0; i < arr.Length; i++)

arr[i] = Math.Round(new Random().NextDouble() * (end - begin) + begin, 0);

Console.WriteLine($"[{String.Join(", ", arr)}]");

Console.WriteLine("Введите число для проверки вхождений: ");

int s = Convert.ToInt32(Console.ReadLine()), result = 0;

for (int j = 0; j < arr.Length; j++)
if (arr[j] == s)
result = result + 1;

Console.WriteLine(result);