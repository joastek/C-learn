
//using System;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//Console.WriteLine("Hello");
//Console.WriteLine("Input the first number");
//var number1= Console.ReadLine();
//int firstNumber = int.Parse(number1) ;

//Console.WriteLine("Input the second number");
//var number2 = Console.ReadLine();
//int secondNumber = int.Parse(number2);

//Console.WriteLine("What do you want to do ?");
//Console.WriteLine("[A]dd numbers");
//Console.WriteLine("[S]ubstract numbers");
//Console.WriteLine("[M]utiply numbers");

//var choice= Console.ReadLine();
//if (choice =="A" || choice == "a")
//{
//    var sum = firstNumber + secondNumber;
//    Console.WriteLine(firstNumber + "+" + secondNumber + "=" +sum);
//}
//else if (choice == "S" || choice == "s")
//{
//    var sum = firstNumber / secondNumber;
//    Console.WriteLine(firstNumber + "/" + secondNumber + "=" + sum);
//}
//else if (choice == "M" || choice == "m")
//{
//    var sum = firstNumber * secondNumber;
//    Console.WriteLine(firstNumber + "*" + secondNumber + "=" + sum);
//}
//else { Console.WriteLine("Invalid choice");
//    Console.WriteLine("Press any key to close");
//}




//using static System.Runtime.InteropServices.JavaScript.JSType;
//int number = 7;
//var result = 1;
//for (int i = 1; i <= number; ++i)
//{
//    result *= i;
//    Console.WriteLine(result);
//}

//Console.ReadLine(); 

var numbers = new[] { 10, -8, 2, 12, -17 };
int nonPositiveCount = 0;
var onlyPositive = GetOnlyPositive(numbers, nonPositiveCount);
foreach (var positiveNumber in onlyPositive)
{
    Console.WriteLine(positiveNumber);
}

Console.WriteLine(nonPositiveCount);
Console.ReadKey();
List<int> GetOnlyPositive(int[] numbers, int countOfnonPositive)
{
    countOfnonPositive = 0;
    var result = new List<int>();
    foreach (int number in numbers)
    {
        if (number > 0)
        { result.Add(number); }
    }
    return result;
}