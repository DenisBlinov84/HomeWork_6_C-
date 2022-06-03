// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int CountNum()
{
    int count = 0;
    string word;

    while (true)
    {
        Console.Write("Output any number: ");
        word = Console.ReadLine();

        if (word == "") return count;
        else if (int.Parse(word) > 0) count += 1;
    }
}
Console.WriteLine($"You entered {CountNum()} numbers greater than 0");
