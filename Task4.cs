Console.WriteLine("Enter your age:");
byte age = byte.Parse(Console.ReadLine());

if (age <= 12 || age >= 60)
{
    Console.WriteLine($"ticket = 5AZN");
}
 else if (age >= 13 && age <=59)
{
    Console.WriteLine("Are you a student (true/false)?");
    bool answer = bool.Parse(Console.ReadLine());
    if (answer == true)
    {
        Console.WriteLine($"ticket = 7.5AZN");
    }
    else
    {
        Console.WriteLine($"ticket = 10AZN");
    }
}
else
{
    Console.WriteLine("Please Enter Right Informations...");
}
