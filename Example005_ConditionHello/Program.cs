// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите свое имя: ");

string username = Console.ReadLine();

if(username == "Маша")
{
    Console.WriteLine("Урррааа! Это МАША!");
}
else
{
    Console.WriteLine("Привет, " + username);
}