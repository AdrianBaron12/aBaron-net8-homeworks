///Exercise 1
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
    Console.WriteLine($"Maximum number is: {firstNumber}");
else if (secondNumber >= thirdNumber && secondNumber >= firstNumber)
    Console.WriteLine($"Maximum number is: {secondNumber}");
else
    Console.WriteLine($"Maximum number is: {thirdNumber}");

if (firstNumber <= secondNumber && firstNumber <= thirdNumber)
    Console.WriteLine($"Minimum number is: {firstNumber}");
else if (secondNumber <= thirdNumber && secondNumber <= firstNumber)
    Console.WriteLine($"Minimum number is: {secondNumber}");
else
    Console.WriteLine($"Minimum number is: {thirdNumber}");

///Exercise 2

int resultMaximum = firstNumber >= secondNumber && firstNumber >= thirdNumber ? firstNumber :
                    secondNumber >= firstNumber && secondNumber >= thirdNumber ? secondNumber :
                    thirdNumber >= firstNumber && thirdNumber >= secondNumber ? thirdNumber :
                    0;

Console.WriteLine($"Maximum number using ternary operator is: {resultMaximum}");

int resultMinimum = firstNumber <= secondNumber && firstNumber <= thirdNumber ? firstNumber :
                    secondNumber <= firstNumber && secondNumber <= thirdNumber ? secondNumber :
                    thirdNumber <= firstNumber && thirdNumber <= secondNumber ? thirdNumber :
                    0;
Console.WriteLine($"Minimum number using ternary operator is: {resultMinimum}");

///Exercise 3

Console.WriteLine("Enter the number of days: ");
int numberDays=Convert.ToInt32(Console.ReadLine());

int year = numberDays / 365;
int month = (numberDays%365)/30;
int day = (numberDays%365)%30;

if (year > 1)
{
    Console.WriteLine($"{year} years");
}
else
{
    Console.WriteLine($"{year} year");
}

if (month > 1)
{
    Console.WriteLine($"{month} months");
}
else
{
    Console.WriteLine($"{month} month");
}

if (day > 1)
{
    Console.WriteLine($"{day} days");
}
else
{
    Console.WriteLine($"{day} day");
}

///Exercise 4
Console.Write("Enter the Physics mark: ");
int Physics = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Chemistry mark: ");
int Chemistry = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Biology mark: ");
int Biology = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Mathematics mark: ");
int Mathematics = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Computer Science mark: ");
int computerScience = Convert.ToInt32(Console.ReadLine());

float result = (Physics+Chemistry+Biology+Mathematics+computerScience)/5.00f;


if (result >= 90)
{
    Console.WriteLine($"Percentage = {result} and grade is A");
}
else if (result >= 80 && result <90)
{
    Console.WriteLine($"Percentage = {result} and grade is B");
}
else if (result >= 70 && result < 80)
{
    Console.WriteLine($"Percentage = {result} and grade is C");
}
else if (result >= 60 && result < 70)
{
    Console.WriteLine($"Percentage = {result} and grade is D");
}
else if (result >= 40 && result < 60)
{
    Console.WriteLine($"Percentage = {result} and grade is E");
}
else
{
    Console.WriteLine($"Percentage = {result} and grade is F");
}

///Exercise 5

Console.WriteLine("Input a grade (E,V,G,A,F): ");
switch (Console.ReadLine())
{
    case "E":
        {
            Console.WriteLine("Excelent");
            break;
        }
    case "V":
        {
            Console.WriteLine("Very Good");
            break;
        }
    case "G":
        {
            Console.WriteLine("Good");
            break;
        }
    case "A":
        {
            Console.WriteLine("Average");
            break;
        }
    case "F":
        {
            Console.WriteLine("Fail");
            break;
        }
    default:
        {
            Console.WriteLine("Not a valid grade");
            break;
        }
}


///Exercise 6

Console.WriteLine("Input a temperature: ");
int temp = Convert.ToInt32(Console.ReadLine());

if (temp <= 0)
{
    Console.WriteLine("Freezing weather");
}
else if (temp > 0 && temp <= 10)
{
    Console.WriteLine("Very Cold weather");
}
else if (temp > 10 && temp <= 20)
{
    Console.WriteLine("Cold weather");
}
else if (temp > 20 && temp <= 30)
{
    Console.WriteLine("Normal in Temp");
}
else if (temp > 30 && temp <= 40)
{
    Console.WriteLine("It's Hot");
}
else
{
    Console.WriteLine("It's Very Hot");
}

