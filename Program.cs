// string text = "Код 2026";
// Console.WriteLine(text.Length);
// Console.WriteLine(text[0]);
// Console.WriteLine(text[text.Length - 1]);
// int CountCharacter(string text, char target)
// {
//     int count = 0;

//     foreach (char symbol in text)
//     {
//         if (symbol == target)
//         {
//             count++;
//         }
//     }

//     return count;
// }

int CountCharacter(string text, char target)
{
    int count = 0;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
        {
            count++;
        }
    }

    return count;
}
Console.WriteLine(CountCharacter("мама", 'м'));
// Console.WriteLine(CountCharacter("Код 2026", ' '));
// Console.WriteLine(CountCharacter("", 'а'));

int CountDigits(string text)
{
    int count = 0;

    foreach (char symbol in text)
    {
        if (char.IsDigit(symbol))
        {
            count++;
        }
    }

    return count;
}
int CountLetters(string text)
{
    int c1 = 0;
    foreach (char symbol in text)
    {
        if (char.IsLetter(symbol))
        {
            c1++;
        }
    }
    return c1;
}
// Console.WriteLine(CountDigits("Код 2026!"));
// Console.WriteLine(CountLetters("Код 2026!"));

// int CountDigits(string text)
// {
//     int count = 0;

//     foreach (char symbol in text)
//     {
//         if (char.IsDigit(symbol))
//         {
//             count += 1;
//         }
//     }

//     return count;
// }
// Console.WriteLine(CountDigits("A2B3"));

// int FindCharacterIndex(string text, char target)
// {
//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i] == target)
//         {
//             return i;
//         }
//     }

//     return -1;
// }
// 
// Console.WriteLine(FindCharacterIndex("banana", 'b'));
// Console.WriteLine(FindCharacterIndex("banana", 'z'));
// Console.WriteLine(FindCharacterIndex("", 'a'));
int FindCharacterIndex(string text, char target)
{
    int index = -1;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
        {
            return i;
        }
    }

    return index;
}
//string sample = "  Привет, C#!  ";

// string trimmed = sample.Trim();
// string upper = sample.ToUpper();
// string lower = sample.ToLower();
// string replaced = sample.Replace(' ', '_');

// Console.WriteLine($"Исходная: [{sample}]");
// Console.WriteLine($"Без пробелов по краям: [{trimmed}]");
// Console.WriteLine($"Верхний регистр: [{upper}]");
// Console.WriteLine($"Нижний регистр: [{lower}]");
// Console.WriteLine($"Замена пробелов: [{replaced}]");
// string sample = "  кот  ";
// string sample1 = sample.Trim();
// Console.WriteLine($"[{sample1}]");

// Console.WriteLine(CountWords("Я изучаю C#"));
// Console.WriteLine(CountWords("  кот  дом  "));
// Console.WriteLine(CountWords(""));
// Console.WriteLine(CountWords("   "));
int CountWords(string text)
{
    string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return words.Length;
}

Console.Write("Введите строку: ");
string text = Console.ReadLine() ?? "";
string trimmed = text.Trim();
string upp = text.ToUpper();
string replaced = text.Replace(' ', '_');
Console.WriteLine(">>> Анализ строки <<<");
Console.WriteLine($"Исходная строка [{text}]");
Console.WriteLine($"Длинна {text.Length}");
Console.WriteLine($"Букв {CountLetters(text)}");
Console.WriteLine($"Цифр {CountDigits(text)}");
Console.WriteLine($"Пробелов {CountCharacter(text, ' ')}");
Console.WriteLine($"Слов {CountWords(text)}");
Console.WriteLine($"Без пробелов по краям [{trimmed}]");
Console.WriteLine($"Вверхний регистр [{upp}]");
Console.WriteLine($"Замена пробелов [{replaced}]");
Console.Write("Введите один символ для поиска: ");
char target = Convert.ToChar(Console.ReadLine());
if (FindCharacterIndex(text, target) == -1)
{
    Console.WriteLine("Символ не найден");
}
else
{
    Console.WriteLine(FindCharacterIndex(text, target));
}
Console.WriteLine(CountLetters("Ёж и C#"));
Console.WriteLine(CountDigits("A0Б9!"));
Console.WriteLine(CountCharacter("aAa", 'a'));
Console.WriteLine(FindCharacterIndex("тест", 'т'));
Console.WriteLine(FindCharacterIndex("", 'т'));
Console.WriteLine(CountWords("  одно   два  "));