using System;

class Program
{
    static void Main()
    {
        string source = "banana";     // исходная строка
        char target = 'a';            // символ для замены
        int startPos = 1;             // начальная позиция
        int n = 2;                    // количество замен

        int result = ReplaceChar(source, target, startPos, n);

        Console.WriteLine("Количество замен: " + result);
        Console.ReadKey();
    }

    static int ReplaceChar(string source, char target, int startPos, int n)
    {
        if (source == null)
            throw new ArgumentNullException("Строка не может быть пустой");

        if (startPos < 0 || startPos >= source.Length)
            throw new ArgumentOutOfRangeException("Неверная позиция начала");

        if (n <= 0)
            throw new ArgumentException("Количество замен должно быть больше нуля");

        char[] chars = source.ToCharArray();
        int count = 0;

        for (int i = startPos; i < chars.Length && count < n; i++)
        {
            if (chars[i] == target)
            {
                chars[i] = '*';
                count++;
            }
        }

        Console.WriteLine("Результат обработки: " + new string(chars));
        return count;
    }
}
