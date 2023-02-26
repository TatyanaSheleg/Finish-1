Console.Clear();
Console.WriteLine("Введите слова через запятую: ");
string text = Console.ReadLine();
char[] separators = new char[] { ',', ' ' };
string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

int count = 0;
foreach (string word in words)
{
    if (word.Length < 4)
    {
        Console.WriteLine(word);
        count++;
    }
}
if (count == 0)
    Console.WriteLine("В заданной строке отсутствуют слова с количеством символов равным или меньше 3");