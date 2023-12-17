//Задайте произвольную строку. Выясните, является ли она палиндромом.
Console.WriteLine("Задайте произвольную строку:");
string str = Console.ReadLine();
void StringIsPalindrom(string str)
{
    for (int i = 0; i < str.Length/2; i++)
    {
        if (str[i] == str[str.Length-i-1])
        {
            Console.WriteLine("Да, это строка является полиндромом.");
            break;
        }
        else 
        {
            Console.WriteLine("Нет, это строка не является полиндромом.");
            break;
        }
    }
}
Console.WriteLine();
StringIsPalindrom(str);