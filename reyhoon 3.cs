using System.Security.Cryptography.X509Certificates;

Char y;
do
{
    y = Console.ReadKey().KeyChar;
}
while (!Char.IsDigit(y));
Console.WriteLine("You enter + Y");


