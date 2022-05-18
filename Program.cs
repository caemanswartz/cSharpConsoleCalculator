Console.WriteLine("Console Calcluclator in c#/r");
Console.WriteLine("--------------------------/n");
int num1=0;
int num2=0;
char op='?';
var result=0;
Console.WriteLine("Type a number, and then press Enter");
num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type Another number, and then press Enter");
num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Choose an option from the follwoing list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.WriteLine("\tu - Modulo");
switch (Console.ReadLine())
{
    case "a":
        result=num1+num2;
        op='+';
        break;
    case "s":
        result=num1-num2;
        op='-';
        break;
    case "m":
        result=num1*num2;
        op='*';
        break;
    case "d":
        result=num1/num2;
        op='/';
        break;
    case "u":
        result=num1%num2;
        op='%';
        break;
    default:
        Console.WriteLine("Unknown operation!");
        break;

}
Console.WriteLine($"Your result: {num1} {op} {num2} = {result}");
Console.WriteLine("Press any key to slose the Calculator console app...");
Console.ReadKey();