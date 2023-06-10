Console.Write("Enter your name, please: ");
string user = Console.ReadLine();
if (user.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(user);
}