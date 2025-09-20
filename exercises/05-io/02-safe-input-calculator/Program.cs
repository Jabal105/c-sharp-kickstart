// Exercise 05-02: Safe Input Calculator
// Create a calculator that safely handles invalid user input

using System;

Console.WriteLine("Safe Input Calculator");
Console.WriteLine("====================");
Console.WriteLine("");

// Get first number
Console.Write("Enter first number: ");
double firstNumber;
// Use a do-while loop to repeatedly ask for input until a valid number is entered
while (!double.TryParse(Console.ReadLine(), out firstNumber))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    Console.Write("Enter first number: ");
}

// Get second number
Console.Write("Enter second number: ");
double secondNumber;
while (!double.TryParse(Console.ReadLine(), out secondNumber))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    Console.Write("Enter second number: ");
}

// Get operation
string operation;
while (true)
{
    Console.Write("Enter operation (+, -, *, /): ");
    operation = Console.ReadLine();
    if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
    {
        break; // Exit the loop if the operation is valid
    }
    else
    {
        Console.WriteLine("Error: Invalid operation! Please enter +, -, *, or /.");
    }
}

// Perform calculation
double result = 0;
bool isValidOperation = true;

if (operation == "+")
{
    result = firstNumber + secondNumber;
}
else if (operation == "-")
{
    result = firstNumber - secondNumber;
}
else if (operation == "*")
{
    result = firstNumber * secondNumber;
}
else if (operation == "/")
{
    if (secondNumber != 0)
    {
        result = firstNumber / secondNumber;
    }
    else
    {
        Console.WriteLine("Error: Cannot divide by zero!");
        isValidOperation = false;
    }
}

// Display result only if the operation was valid
if (isValidOperation)
{
    Console.WriteLine($"Calculation: {firstNumber} {operation} {secondNumber} = {result:F2}");
}