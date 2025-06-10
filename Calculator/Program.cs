//Calculator
Console.Write("Enter first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.Write("Enter an operator (+, -, *, /): ");
string operation = Console.ReadLine();

string result = operation switch
{
    "+" => $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}",
    "-" => $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}",
    "*" => $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}",
    "/" => secondNumber != 0 ? $"{firstNumber} / {secondNumber} = " +
                $"{firstNumber / secondNumber}" : "Cannot divide by zero.",
    _ => "Invalid operator."
};

Console.WriteLine(result);
