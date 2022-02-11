// Assignmnet 3
Console.WriteLine("Hello, World!");

//Test your knowledge
//1. What are the six combinations of access modifierkeywords and what do they do?
//Public: accessible outside the class.
//Protected: not accessible outside the class, but derived classes still have access.
//Private: not accessible outside the class.
//Internal: its only visible within the compile unit.
//Protected internal: only accessible within the compile unit or a derived class in another compile unit.
//Private protected: can only be acces within the derived class of the compile unit

//2. What is the difference between the static, const, and readonly keywords when applied to a type member?
//Constant fields/variables must be assigned a value at the time of declaration and cannot be modified. (compile constant)
//ReadOnly field can be initialized at declaration or within the construction of the class. (run-time constant)
//Static member is not tied to a specific object, ehich mkes them common to all objects.

//3.What does a constructor do?
//A constructor runs when the class is created.

//4.Why is the partial keyword useful?
//It provides a special ability to implement the functionality of a single class into multiple files and all these files are
//combined into a single class file when the application is compiled.

//5.What is a tuple?
//A tuple is a data structure that contains a sequence of elements of different data types.

//6.What does the C# record keyword do?
//It define a reference type that provides built-in functionality for encapsulating data.

//7.What does overloading and overriding mean?
//Overloading is having mutiple methods of the same name with different parameters to take.
//Overriding is replacing the parent method in a derived class with a new method using the same name for the method.

//8.What is the difference between a field and a property?
//Fields are the direct variables to a class that should be kept private.
//Property allow for acces to the fields in a control way. (gets and sets)

//9.How do you make a method parameter optional?
//By assigning it default values if the parameter does not get pass.

//10.What is an interface and how is it different from abstract class?
//Interface is for implementing peripheral abilities to a class that inherites it.
//Compare to abstract class, interface only contains declarations, no definitions.
//Interfaces aslos differs from abstract in that it can only have public access and does not contain static members.
//Multiple interface and multiple inheritance can be achieved with interface compared to abstract.

//11.What accessibility level are members of an interface?
//Public because everything in an interface is public.

//12.True/False. Polymorphism allows derived classes to provide different implementationsof the same method.
//True

//13.True/False. The override keyword is used to indicate that a method in a derived class is providing its own
//implementation of a method.
//True

//14.True/False. The new keyword is used to indicatethat a method in a derived class is providing its own implementation of a method.
//False

//15.True/False. Abstract methods can be used in a normal (non-abstract) class.
//False

//16.True/False. Normal (non-abstract) methods can be used in an abstract class.
//True

//17.True/False.Derived classes can override methods that were virtual in the base class.
//True

//18.True/False.Derived classes can override methods that were abstract in the base class.
//True

//19.True/False.In a derived class, you can override a method that was neither virtual non  abstract in the base class.
//False

//20.True/False. A class that implements an interface does not have to provide an implementation for all of the members of
//the interface.
//False

//21.True/False. A class that implements an interfaceis allowed to have other members that aren’t defined in the interface.
//True

//22.True/False. A class can have more than one base class.
//False

//23.True/False. A class can implement more than one interface.
//True

//Working With Methods
Assignment3Class runClass = new Assignment3Class();
//1) Reverse Array: GenerateNumbers(), Reverse(array), PrintNumbers(array).
int[] numbers = runClass.GenerateNumbers();
runClass.Reverse(numbers);
runClass.PrintNumbers(numbers);

//2) Fibonacci sequence
Console.WriteLine("Fibonacci Number:");
for (int z = 1; z <= 10; z++)
{
    Console.Write(runClass.FibonacciNumber(z) + " ");
}
Console.WriteLine("");

//Designing and Building Classes using object-oriented principles
//OOP: /Abstraction/, /Encapsulation/, /Inheritance/ and /Polymorphism/
//1-6)
Instructor proffesor = new Instructor(5, 2, false);
proffesor.CalculateAge(new DateTime(2000, 10, 10));
proffesor.Name = "Bob";
Console.WriteLine($"Proffesor {proffesor.Name} is {proffesor.Age} years old");
proffesor.TaskToDo();
Student student1 = new Student(6);
student1.Name = "Sebastian";
student1.TaskToDo();
student1.CalculateAge(new DateTime(2010, 10, 10));
Console.WriteLine($"Student {student1.Name} is {student1.Age} years old");

//7) Color & Ball Test
Console.WriteLine("\nCreating some Ball objects:");
Ball ball1 = new Ball(6);
Ball ball2 = new Ball(24, 0, 0, 255);
Ball ball3 = new Ball(17, 100, 100, 0);
Ball ball4 = new Ball(36, 100, 0, 100);
Ball ball5 = new Ball(15, 100, 200, 100);
//Throwing
ball1.Throw();
ball1.Throw();
ball2.Throw();
ball3.Throw();
ball3.Throw();
ball4.Throw();
ball4.Throw();
ball4.Throw();
ball5.Throw();
Console.WriteLine($"Ball 1 has been thrown: {ball1.ThrownCount} times");
Console.WriteLine($"Ball 2 has been thrown: {ball2.ThrownCount} times");
Console.WriteLine($"Ball 3 has been thrown: {ball3.ThrownCount} times");
Console.WriteLine($"Ball 4 has been thrown: {ball4.ThrownCount} times");
Console.WriteLine($"Ball 5 has been thrown: {ball5.ThrownCount} times");
//Pop
Console.WriteLine("Poping ball 2 and 3");
ball2.Pop();
ball3.Pop();
//Throw Again
ball1.Throw();
ball1.Throw();
ball2.Throw();
ball3.Throw();
ball3.Throw();
ball4.Throw();
ball4.Throw();
ball4.Throw();
ball5.Throw();
Console.WriteLine($"Ball 1 has been thrown: {ball1.ThrownCount} times");
Console.WriteLine($"Ball 2 has been thrown: {ball2.ThrownCount} times");
Console.WriteLine($"Ball 3 has been thrown: {ball3.ThrownCount} times");
Console.WriteLine($"Ball 4 has been thrown: {ball4.ThrownCount} times");
Console.WriteLine($"Ball 5 has been thrown: {ball5.ThrownCount} times");
