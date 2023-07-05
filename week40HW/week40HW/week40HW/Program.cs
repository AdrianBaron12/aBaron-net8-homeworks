using Week40.Book1;
using Week40.Product1;
using Week40.Animal1;
using Week40.Calculator1;
using Week40.Faculty1;

Console.WriteLine("------------------------EXERCISE 1---------------------------");

Book book = new Book("War and Peace", "Lev Tolstoy", 1869);

Console.WriteLine(book.GetTitle());
Console.WriteLine(book.GetAuthor());
Console.WriteLine(book.GetYear());

book.SetTitle("Anna Karenina");
book.SetAuthor("Lev Tolstoy");
book.SetYear(1877);

Console.WriteLine();

Console.WriteLine(book.GetTitle());
Console.WriteLine(book.GetAuthor());
Console.WriteLine(book.GetYear());

Console.WriteLine("------------------------EXERCISE 2---------------------------");

Product product = new Product("Apple", 0.99, 10);

Console.WriteLine(product.GetName());
Console.WriteLine(product.GetPrice());
Console.WriteLine(product.GetQuantity());

product.SetName("Orange");
product.SetPrice(1.49);
product.SetQuantity(20);

Console.WriteLine();

Console.WriteLine(product.GetName());
Console.WriteLine(product.GetPrice());
Console.WriteLine(product.GetQuantity());

Console.WriteLine("------------------------EXERCISE 3---------------------------");

Animal animal = new Animal("Max", "Dog", "Labrador Retriever", 2, "Yellow", 75, true);

Console.WriteLine(animal.GetName()); // Outputs "Max"
Console.WriteLine(animal.GetSpecies()); // Outputs "Dog"
Console.WriteLine(animal.GetBreed()); // Outputs "Labrador Retriever"
Console.WriteLine(animal.GetAge()); // Outputs 2
Console.WriteLine(animal.GetColor()); // Outputs "Yellow"
Console.WriteLine(animal.GetWeight()); // Outputs 75
Console.WriteLine(animal.GetIsSpayedOrNeutered()); // Outputs true

Console.WriteLine();

animal.SetName("Buddy");
animal.SetSpecies("Cat");
animal.SetBreed("Siamese");
animal.SetAge(5);
animal.SetColor("Gray");
animal.SetWeight(12);
animal.SetIsSpayedOrNeutered(false);

Console.WriteLine();

Console.WriteLine(animal.GetName()); // Outputs "Buddy"
Console.WriteLine(animal.GetSpecies()); // Outputs "Cat"
Console.WriteLine(animal.GetBreed()); // Outputs "Siamese"
Console.WriteLine(animal.GetAge()); // Outputs 5
Console.WriteLine(animal.GetColor()); // Outputs "Gray"
Console.WriteLine(animal.GetWeight()); // Outputs 12
Console.WriteLine(animal.GetIsSpayedOrNeutered()); // Outputs false

Console.WriteLine("------------------------EXERCISE 4---------------------------");


Calculator calculator = new Calculator();

Console.WriteLine(calculator.Add(2, 3)); // Outputs 5
Console.WriteLine(calculator.Subtract(5, 2)); // Outputs 3
Console.WriteLine(calculator.Multiply(3, 4)); // Outputs 12
Console.WriteLine(calculator.Divide(10, 5)); // Outputs 2
Console.WriteLine(calculator.Power(2, 3)); // Outputs 8
Console.WriteLine(calculator.SquareRoot(9)); // Outputs 3

Console.WriteLine("------------------------EXERCISE 5---------------------------");

University myUniversity = new University("My University");

Student john = new Student("John", "Doe", 123456, 3.8);
Student jane = new Student("Jane", "Smith", 654321, 3.6);

myUniversity.AddStudent(john);
myUniversity.AddStudent(jane);

Faculty mary = new Faculty("Mary", "Jones", 111111, new List<string> { "Math", "Physics" });
Faculty bob = new Faculty("Bob", "Smith", 222222, new List<string> { "English", "History" });

myUniversity.AddFaculty(mary);
myUniversity.AddFaculty(bob);

Console.WriteLine(myUniversity.GetStudentCount()); // Outputs 2
Console.WriteLine(myUniversity.GetFacultyCount()); // Outputs 2

Console.WriteLine("------------------------EXERCISE 6---------------------------");



