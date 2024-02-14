
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello");
Console.WriteLine("Input the first number");
var number1= Console.ReadLine();
int firstNumber = int.Parse(number1) ;
if (!firstNumber)
{
    var sum = firstNumber + secondNumber;
    Console.WriteLine(firstNumber + "+" + secondNumber + "=" + sum);
}
Console.WriteLine("Input the second number");
var number2 = Console.ReadLine();
int secondNumber = int.Parse(number2);

Console.WriteLine("What do you want to do ?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubstract numbers");
Console.WriteLine("[M]utiply numbers");

var choice= Console.ReadLine();
if (choice =="A" || choice == "a")
{
    var sum = firstNumber + secondNumber;
    Console.WriteLine(firstNumber + "+" + secondNumber + "=" +sum);
}
else if (choice == "S" || choice == "s")
{
    var sum = firstNumber / secondNumber;
    Console.WriteLine(firstNumber + "/" + secondNumber + "=" + sum);
}
else if (choice == "M" || choice == "m")
{
    var sum = firstNumber * secondNumber;
    Console.WriteLine(firstNumber + "*" + secondNumber + "=" + sum);
}
else { Console.WriteLine("Invalid choice");
    Console.WriteLine("Press any key to close");
}