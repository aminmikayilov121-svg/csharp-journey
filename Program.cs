Console.Write("Adın nədir");
string? name = Console.ReadLine();
Console.WriteLine($"Salam, {name}!");
Console.Write("Yaşın neçədir? ");
int age = int.Parse(Console.ReadLine()!);
if (age >= 18)
{
    Console.WriteLine("Yetkinsən");
}
else
{
    Console.WriteLine("Yetkin deyilsən");
}
