

using System.Collections.ObjectModel;

Console.WriteLine("-------------------------EXERCISE 1----------------------------");


int[] numbers1= new int[5] {1,2,3,4,5};
int suma1 = 0;

for(int i = 0; i < numbers1.Length; i++)
{
    if (numbers1[i]%2 == 0)
    {
        suma1 += numbers1[i]; 
    }
}
Console.WriteLine(suma1);




Console.WriteLine("-------------------------EXERCISE 2----------------------------");

int[] numbers2 = new int[]{3,4,4,5,9};

Dictionary<int,int> duplicates = new Dictionary<int,int>();

for(int i=0; i<numbers2.Length; i++)
{
    if (duplicates.ContainsKey(numbers2[i]))
    {
        duplicates[numbers2[i]]++;
    }
    else
    {
        duplicates[numbers2[i]]=1;
    }
}
foreach(var i in duplicates)
{
    if (i.Value > 1)
    {
        Console.WriteLine(i.Key);
    }

}

Console.WriteLine("-------------------------EXERCISE 3----------------------------");

List<string> letters3 = new List<string>();
letters3.Add("a");
letters3.Add("b");
letters3.Add("b");
letters3.Add("c");
letters3.Add("c");
letters3.Add("d");
letters3.Add("d");
List<string> uniqueLetters3 = new List<string>();

foreach(var i in letters3)
{
    if (!uniqueLetters3.Contains(i))
    {
        uniqueLetters3.Add(i);
    }
}

foreach(string item in uniqueLetters3)
{
    Console.WriteLine(item);
}

Console.WriteLine("-------------------------EXERCISE 4----------------------------");

int[] numbers3 = new int[] { 3, 4, 4, 5, 9 };

Dictionary<int, int> duplicates2 = new Dictionary<int, int>();

for (int i = 0; i < numbers2.Length; i++)
{
    if (duplicates2.ContainsKey(numbers2[i]))
    {
        duplicates2[numbers2[i]]++;
    }
    else
    {
        duplicates2[numbers2[i]] = 1;
    }
}

foreach (KeyValuePair<int,int> p in duplicates)
{
    Console.WriteLine($"{p.Key} apare de {p.Value}");
}

Console.WriteLine("-------------------------EXERCISE 5----------------------------");

int[] firstArray = new int[6] {3,4,5,6,7,8};
int[] oddArray = new int[3];
int[] evenArray = new int[3];

int lenghtEven = 0;
int lenghtOdd = 0;

for(int i = 0;i < firstArray.Length; i++)
{
    int number = firstArray[i];

    if(i%2 == 0)
    {
        evenArray[lenghtEven++] = number;    
    }
    else
    {
        oddArray[lenghtOdd++] = number;
    }
}


Console.WriteLine("Odd array : ");
foreach(int i in oddArray)
{
    Console.WriteLine(i);
}

Console.WriteLine("Even Array: ");
foreach (int i in evenArray)
{
    Console.WriteLine(i);
}

Console.WriteLine("-------------------------EXERCISE 6----------------------------");


Console.WriteLine("Introduceti numarul a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduceti numarul b");
int b = Convert.ToInt32(Console.ReadLine());
List<int> collection = new List<int>();


if (a < b)
{

    for (int i = a; i <= b; i++)
    {
        collection.Add(i);
    }
}
else
{
    for (int i = b; i <=a; i++)
    {
        collection.Add(i);
    }

}

Console.WriteLine("Numerele afisate: ");

foreach (int num in collection)
{
    if (num % 3 == 0)
    {
        Console.WriteLine(num);
    }
}

Console.WriteLine("-------------------------EXERCISE 7----------------------------");

List<int> FizzBuzzGame = new List<int>();
for(int i = 123; i < 235; i++)
{
    FizzBuzzGame.Add(i);
}

foreach (int num in FizzBuzzGame)
{
    if (num % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if(num%5 == 0) {
        Console.WriteLine("Buzz");
            }
    else if(num%3==0||num%5==0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else { Console.WriteLine(num);
    }
}


Console.WriteLine("-------------------------EXERCISE 8----------------------------");

List<string> names= new List<string>();

int count = 0;
while (count < 10)
{
    names.Add(Console.ReadLine());
    count++;
}
int index=0;
while (index < 6)
{
    string nume1 = names[index];
    Console.WriteLine(nume1);
    index++;
}

Console.WriteLine("-------------------------EXERCISE 9----------------------------");

List<int> intInput = new List<int>();
int number8;

do
{
    number8=Convert.ToInt32(Console.ReadLine());
    if(number8 != 0)
    {
        intInput.Add(number8);
    }

}while(number8 !=0);

foreach (int num in intInput)
{
    Console.WriteLine(num);
}

Console.WriteLine("-------------------------EXERCISE 10----------------------------");

int iterator10 = -1;

do
{
    Console.WriteLine(iterator10);
    if (iterator10 % 21 == 0)
    {
        break;
    }
    iterator10--;

} while (iterator10 >= -123);

Console.WriteLine("-------------------------EXERCISE 11----------------------------");

List<string> name11 = new List<string>();

int indexNume11 = 10;
while (indexNume11 != 0)
{
    name11.Add(Console.ReadLine());
    indexNume11--;
}

foreach(string name in name11)
{
    
    if (name.StartsWith("a")||name.StartsWith("A") || name.StartsWith("b") || name.StartsWith("B"))
    {
        continue;
    }
    Console.WriteLine(name);
}
