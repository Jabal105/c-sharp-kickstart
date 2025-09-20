// Exercise 03-01: Personal Information
// Create a program that stores and displays personal information using variables

using System;
using System.Security.Cryptography;

// TODO: Declare variables for personal information
// Use appropriate data types: string, int, double, bool

// Example:
// string firstName = "Your Name";

Console.WriteLine("Personal Information");
Console.WriteLine("===================");
string firstName = "Emma";
string lastName = "Watson";

int age = 17;
double height = 165.5;
bool isStudent = true;
int favoriteNumber = 7;
int currentYear = 2024;

Console.WriteLine("Name: " + firstName + " " + lastName);
Console.WriteLine("Age: " + age + " years old");
Console.WriteLine("Favorite Number: " + favoriteNumber);
Console.WriteLine("Height: " + height + " cm");
Console.WriteLine("Is a student: " + isStudent);
Console.WriteLine("Year of birth: " + (currentYear - age));





// TODO: Display the information using the variables
// Format: "Name: " + firstName + " " + lastName

// TODO: Calculate and display birth year
// int currentYear = 2024;
// int birthYear = currentYear - age;