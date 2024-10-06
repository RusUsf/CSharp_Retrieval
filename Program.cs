Console.WriteLine("Hello World, I am learning C Sharp programming!");


//// Q1: How to write a "Hello, World!" program?
//Console.WriteLine("Hello, world!");
//Console.WriteLine("I am capable of learning C# programming language. I am smart, intelligent, and hardworking. I have the ability to learn new things, including C#");

//// Q2: How to declare and initialize an integer variable?
//int myIntegerOne = 37;
//Console.WriteLine($"The value of myIntegerOne: {myIntegerOne+1}");

//// Q3: How to perform a basic conditional check using an if statement?

//Console.WriteLine("Please, enter your age:");
//string myIntegerTwo = Console.ReadLine();
//int myIntegerTree = int.Parse(myIntegerTwo);
//if (myIntegerTree == 37)
//    Console.WriteLine($"The value of the myIntegerTwo: {myIntegerTree}");
//else
//    Console.WriteLine("The value of the myIntegerTwo is not 37!");

//// Q4: What is the correct way to define a method that adds two numbers?
//Console.WriteLine($"The sum of 3 and 5 is: {myAddTwoNumbers(3, 5)}");
//static int myAddTwoNumbers(int numOne, int numTwo)
//{
//    return numOne + numTwo;
//}

//// Q5: How can you loop through an array of integers using a foreach loop?
//int[] myArrayOne = new int[]{ 1, 2, 3, 4, 5, 6 };
//string[] myArrayTwo = new string[] { "Curiosity", "Courage", "Creativity" };

//Console.WriteLine("\n\nmyArrayOne:");
//foreach (int i in myArrayOne)
//    Console.Write(i+", ");
//Console.WriteLine("\n\nmyArrayTwo:");
//foreach (string j in myArrayTwo)
//    Console.Write(j+", ");
//Console.WriteLine("\n\nUsing string.Join() method");
//Console.WriteLine(string.Join(", ", myArrayOne));
//Console.WriteLine(string.Join(", ",myArrayTwo));


//// Q6: How can you define a class with a property named Age?
//// Q7: How do you create an object of the class Person?

//Person personOne = new Person(27);
//Person.TheNextYearAge(personOne.Age);
//Person.TheNextYearAge(37);

//public class Person
//{
//    public int Age { get; set; }
//    public Person(int age = 0)
//    {
//        Age = age;
//    }

//    public static void TheNextYearAge(int age = 0)
//    {
//        Console.WriteLine($"The next year you will be {age+1}");
//    }
//}



//// Q8: How do you handle exceptions using try-catch?
//int myIntOne;
//try
//{
//    Console.WriteLine($"Enter number one:");
//    myIntOne = int.Parse(Console.ReadLine());
//}
//catch (FormatException ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");

//}


//// Q9: How do you read a line of input from the console?
//Console.WriteLine($"enter number one:");
//string myStringOne = Console.ReadLine();
//int myIntOne;
//while (!int.TryParse(myStringOne, out myIntOne))
//{
//    Console.WriteLine("Invalid input. Please enter an integer for number one:");
//    myStringOne = Console.ReadLine();
//}

//Console.WriteLine($"enter number two:");
//string myStringTwo = Console.ReadLine();
//int myIntTwo;
//while (!int.TryParse(myStringTwo, out myIntTwo))
//{
//    Console.WriteLine("Invalid input. Please enter an integer for number two:");
//    myStringTwo = Console.ReadLine();
//}

//if (myIntOne > myIntTwo)
//    Console.WriteLine($"The nubmer {myIntOne} is greater than the number {myIntTwo}");
//else if (myIntTwo > myIntOne) Console.WriteLine($"The number {myIntTwo} is greater than the  number {myIntOne}");
//else
//    Console.WriteLine($"The number {myIntOne} is equal to {myIntTwo}");


//// Q10: How can you define an enumeration?
//Console.WriteLine($"The {(int)days.Sunday} day of the week is {days.Sunday}");
//Console.WriteLine($"The {(int)days.Monday} day of the week is {days.Monday}");
//Console.WriteLine($"The {(int)days.Tuesday} day of the week is {days.Tuesday}");
//public enum days
//{
//    Sunday = 1,
//    Monday,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday,
//    Saturday
//};


//// Q11: How can you concatenate strings?
//string concatenatedString = "My Name is:" + " Ruslan" + " Dubas.";
//Console.WriteLine(concatenatedString);

//// Q12: What is a correct way to define a constant variable?
//const string myName = "RuslanDubas";

//// Q13: How do you write a switch statement?
//CheckColor("green");
//void CheckColor(string color)
//{
//    switch (color)
//    {
//        case "green":
//            Console.WriteLine("green");
//            break;
//        case "black":
//            Console.WriteLine("black");
//            break;
//        case "yellow":
//            Console.WriteLine("yellow");
//            break;
//        default: Console.WriteLine("Enter green, black or yellow only!");
//            break;
//    }
//}

//// Q14: How do you declare and use a delegate?
//MyDelegate myDelegate = ShowMessage;
//myDelegate("Hello, Delegate");

//MyDelegateAdd myDelegateAdd = AddTwoNumbers;
//myDelegateAdd(3, 5);

//void ShowMessage(string message) { Console.WriteLine(message); }

//void AddTwoNumbers(int a, int b)
//{
//    Console.WriteLine($" The {a} + {b} = {a + b}");
//}

//public delegate void MyDelegate(string message);
//public delegate void MyDelegateAdd(int a, int b);

//// Q15: How do you define and call a lambda expression?
//Func<int, int, int> add = (x, y) => x + y;
//int sum = add(3, 4);
//Console.WriteLine(sum);

//// Q16: How can you instantiate a list of integers?
//using System.ComponentModel.DataAnnotations;

//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
//Console.WriteLine(numbers.Contains(3));
//Console.WriteLine(numbers[0]);
//Console.WriteLine(string.Join(" ", numbers));
//numbers.Add(7);
//Console.WriteLine(string.Join(" ",numbers));
//numbers.Remove(7);
//Console.WriteLine(string.Join(" ",numbers));

// Q17: How do you convert a string to an integer?
//int number = int.Parse("42");
//Console.WriteLine(number);

//// Q18: How do you define a structure?
//Point point = new() { X = 5, Y = 6 };
//Console.WriteLine(point.X);
//Console.WriteLine(point.Y);
//public struct Point { public int X; public int Y; }
//// Q19: How can you define and start a new thread?
//// Q20: How to define an interface?
//public interface IAnimal { void Speak(); }

//// Q21: How to use LINQ to query a collection of integers?
//var numbers = new List<int> { 1, 2, 3, 4, 5 };
//var evenNumbers = numbers.Where(n => n % 2 == 0);
//Console.WriteLine(String.Join(",", evenNumbers));

//// Q22: How to asynchronously read a text file?
//using System.Security.Cryptography.X509Certificates;

//using (StreamReader reader = new StreamReader($@"C:\Users\rus_d\OneDrive\Desktop\Coding\Laptop\CSharp\CSharp_Retrieval\CSharpQuestions.txt"))
//{
//    string content = await reader.ReadToEndAsync();
//    Console.WriteLine(content);
//}

//// Q23: How to create a property with a private setter?
//MyClass myClass = new MyClass(5);
//Console.WriteLine(myClass.MyProperty);
//Console.WriteLine(myClass.Sum(3, 3));
//StreamReader reader = new StreamReader($@"C:\Users\rus_d\OneDrive\Desktop\Coding\Laptop\CSharp\CSharp_Retrieval\CSharpQuestions.txt");
//Console.WriteLine(myClass.ReadMyFile(reader));
//public class MyClass
//{
//    public int MyProperty { get; private set; }
//    public StreamReader MyReader { get; set; }
//    public MyClass(int myProperty = 3)
//    {
//        this.MyProperty = MyProperty;
//        this.MyReader = MyReader;
//    }

//    public int Sum(int a, int b) => a + b;
//    public string ReadMyFile(StreamReader myReader)
//    {
//        return myReader.ReadToEnd();
//    }
//}




// Q24: How to handle different exceptions using multiple catch blocks?
//try
//{

//}
//catch(FileNotFoundException)
//{

//}
//catch( Exception e)
//{
//    Console.WriteLine("General exception!");
//}

// Q25: How to use string interpolation?
// Q26: How to use the 'using' statement for automatic resource management?
// Q27: How to use extension methods?
// Q28: How to use indexers in a class?
// Q29: How to use named and optional parameters in a method?
// Q30: How to use attributes in C#?
// Q31: How to declare and use a nullable value type?
// Q32: How to implement the Singleton pattern in C#?
// Q33: How to use the 'yield' keyword to create an iterator?
// Q34: How to implement a generic method?
// Q35: How to perform a deep copy of an object?
// Q36: How to check if a string contains another string?
// Q37: How to use the 'async' and 'await' keywords for asynchronous programming?
// Q38: How to implement event handling in C#?
// Q39: How to use the 'ref' keyword to pass a parameter by reference?
// Q40: How to declare and use an anonymous type?
