Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "Kira")
{
   Console.WriteLine("Хай моя дорогая!!!");
}
else
{
   Console.Write("Привет, ");
   Console.Write(username);
}