// Exercise 04-01: Grade Calculator
// Create a program that calculates grades using various operators

using System;

Console.WriteLine("Grade Calculator");
Console.WriteLine("===============");
Console.WriteLine("");

// TODO: Create variables for student information
string studentName = "Alex Johnson";
int pointsEarned = 425;
int totalPoints = 500;

// TODO: Calculate percentage using arithmetic operators
double percentage = (double)pointsEarned / totalPoints * 100;

Console.WriteLine("Student: " + studentName);
Console.WriteLine("Points Earned: " + pointsEarned);
Console.WriteLine("Total Points: " + totalPoints);
Console.WriteLine("Percentage: " + percentage + "%");
Console.WriteLine("");

Console.WriteLine("Grade Analysis:");

// TODO: Use comparison operators to determine letter grade
bool isA = percentage >= 90;
bool isB = percentage >= 80 && percentage < 90;
bool isC = percentage >= 70 && percentage < 80;
bool isD = percentage >= 60 && percentage < 70;

// TODO: Use logical operators for additional analysis
bool passedCourse = percentage >= 60;
bool honorRoll = percentage >= 90;
bool needsImprovement = percentage < 70;
if (isA)
{
    Console.WriteLine("Letter Grade: A");
}
else if (isB)
{
    Console.WriteLine("Letter Grade: B");
}
else if (isC)
{
    Console.WriteLine("Letter Grade: C");
}
else if (isD)
{
    Console.WriteLine("Letter Grade: D");
}
else
{
    Console.WriteLine("Letter Grade: F");
}

Console.WriteLine("Passed Course: " + passedCourse);
Console.WriteLine("Honor Roll (90%+): " + honorRoll);
Console.WriteLine("Needs Improvement: " + needsImprovement);
Console.WriteLine("");
Console.WriteLine("Grade Breakdown:");
Console.WriteLine("A: 90% and above");
Console.WriteLine("B: 80% to 89%");
Console.WriteLine("C: 70% to 79%");
Console.WriteLine("D: 60% to 69%");
Console.WriteLine("F: Below 60% ");
