Console.Clear();

Console.WriteLine("Введите число: ");

string a = Console.ReadLine();
int summa = 0;

for (int i = 0; i < a.Length; i++)
summa = summa + Convert.ToInt32(a[i].ToString());

Console.WriteLine($"Результат: {summa}");