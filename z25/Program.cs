Console.Clear();

Console.WriteLine("Введите число А: ");

int a = Convert.ToInt32(Console.ReadLine()), s = 1;

Console.WriteLine("Введите число B: ");

int b = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= b; i++)
s = s * a;

Console.WriteLine(s);

