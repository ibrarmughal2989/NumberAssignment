using System;

// This class works with two numbers.
class NumberPractice
{
    // This method takes two integers and does not return a value.
    public void ProcessNumbers(int firstNumber, int secondNumber)
    {
        // Add 5 to the first number.
        firstNumber = firstNumber + 5;

        // Print the second number.
        Console.WriteLine(secondNumber);
    }
}

// This class contains the Main method.
class Program
{
    // The program starts here.
    static void Main()
    {
        // Create an object of NumberPractice.
        NumberPractice practice = new NumberPractice();

        // Call the method with two numbers.
        practice.ProcessNumbers(10, 25);

        // Call the method using parameter names.
        practice.ProcessNumbers(firstNumber: 15, secondNumber: 35);
    }
}