using static System.Console;

WriteLine("Hello, World!");

int[] numbers = new int[2];

for (int i = 0; i < 2; i++)
{
    WriteLine("Введіть число:");
    numbers[i] = int.Parse(ReadLine());
}

WriteLine($"Сумма: {numbers.Sum()}");