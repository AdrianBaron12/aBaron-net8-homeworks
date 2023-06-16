///See https://aka.ms/new-console-template for more information
///Console.WriteLine("Hello, World!");

//Exercise 1

int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());

//Addition
Console.WriteLine($"Addition = {firstNumber + secondNumber}");
//Substraction
Console.WriteLine($"Substraction = {firstNumber - secondNumber}");
//Multiplication
Console.WriteLine($"Multiplication = {firstNumber * secondNumber}");
//Division
Console.WriteLine($"Division = {firstNumber / secondNumber}");
//Modulo
Console.WriteLine($"Modulo = {firstNumber % secondNumber}\n");

//Exercise 2

Console.WriteLine(3 + 4);
Console.WriteLine(3 - 4);
Console.WriteLine(3 * 4);
Console.WriteLine(3 / 4);
Console.WriteLine(3 % 4);
int z = 40;
Console.WriteLine(z++);
Console.WriteLine(z--);
Console.WriteLine(z += 5);
Console.WriteLine(z -= 5);

Console.WriteLine();

//Exercise 3

Console.WriteLine(10 == 4);
Console.WriteLine(50 != 4);
Console.WriteLine(true && false);
Console.WriteLine(true || false);
Console.WriteLine(!false);
