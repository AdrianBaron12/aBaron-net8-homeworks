using Week40.Book1;
using Week40.Product1;
using Week40.Animal1;
using Week40.Calculator1;
using week40HW.Exercise6_7;
using Week40.Faculty1;
using week40HW.Exercise2;
using week40HW.Exercise1;

Console.WriteLine("------------------------EXERCISE 1---------------------------");

Crop tomato = new Crop();
tomato.name = "Tomato";

Console.WriteLine($"Crop: {tomato.name} and Stage: {tomato.currentStage}");

tomato.Water();
Console.WriteLine($"Crop: {tomato.name} and Stage: {tomato.currentStage}");

tomato.Water();
Console.WriteLine($"Crop: {tomato.name} and Stage: {tomato.currentStage}");

tomato.Water();
Console.WriteLine($"Crop: {tomato.name} and Stage: {tomato.currentStage}");

tomato.Harvest();
Console.WriteLine($"Crop: {tomato.name} and Stage: {tomato.currentStage}");

Console.WriteLine("------------------------EXERCISE 2---------------------------");

Farm farm = new Farm("Lucky Farm", 13, 100);

farm.AddAnimals(10);
farm.AddAnimals(20);

Console.WriteLine(farm.name);
Console.WriteLine(farm.animalCount);
Console.WriteLine(farm.area);
Console.WriteLine(farm.CalculateDensity());



Console.WriteLine("------------------------EXERCISE 3---------------------------");

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

Console.WriteLine("------------------------EXERCISE 4---------------------------");

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

Console.WriteLine("------------------------EXERCISE 5---------------------------");

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

Console.WriteLine("------------------------EXERCISE 6---------------------------");


Calculator calculator = new Calculator();

Console.WriteLine(calculator.Add(2, 3)); // Outputs 5
Console.WriteLine(calculator.Subtract(5, 2)); // Outputs 3
Console.WriteLine(calculator.Multiply(3, 4)); // Outputs 12
Console.WriteLine(calculator.Divide(10, 5)); // Outputs 2
Console.WriteLine(calculator.Power(2, 3)); // Outputs 8
Console.WriteLine(calculator.SquareRoot(9)); // Outputs 3

Console.WriteLine("------------------------EXERCISE 7---------------------------");

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

Console.WriteLine("------------------------EXERCISE 8---------------------------");

College1 college = new College1
{
    Name = "Smeura Univerity",
    FoundedYear = 2000,
    City = "Smeura City"
};

Student1 student = new Student1("Ion", new DateTime(2020,4,1), new DateTime(2024,5,1), college, new DateTime(1998,4,1));

Professor1 professor1 = new Professor1("Prof. Luca", "Math", "Algebra");

Student1 student1 = new Student1("Mihai Oni", new DateTime(2022,12,7), new DateTime(2026,6,16), college, new DateTime(2000,7,1));
Student1 student2 = new Student1("Eduard Oba", new DateTime(2021,10,9), new DateTime(2025,12,25), college, new DateTime(1999, 4, 1));

List<Student1> students = new List<Student1> { student1, student2 };

Professor1 professor2 = new Professor1("Prof. Ionut", "Physics", "Geometry", students);

student.Print();

Console.WriteLine($"Professor 1: {professor1.Name}");
Console.WriteLine($"Professor 2: {professor2.Name}");
  

