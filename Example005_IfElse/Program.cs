Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "вика")
{
    Console.WriteLine("Ура, Это же Вика!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}