Console.Write("Ведите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "андрей")
{

    Console.WriteLine("Здраствуй мой повелитель");

}
else 
{
    Console.Write("Добрый день, ");
    Console.WriteLine(username);

}