//Assignment 4

//Test Your Knowledge
//1.Describe the problem generics address.
//The dry principle to not repeat, losing type-safety, and unwanted boxing problems get address by generics

//2.How would you create a list of strings, using the generic List class?
//List<string> genericStringList = new List<string>();

//3.How many generic type parameters does the Dictionary class have?
//It has two generic type parameters
//Dictionary<int, string> dictionaryTest = new Dictionary<int, string>();

//4.True/False. When a generic class has multiple type parameters, they must all match.
//False

//5.What method is used to add items to a List object?
//Add method is used to add items to a list

//6.Name two methods that cause items to be removed from a List.
//Clear method removes all items
//Remove method removes the first item to be added or a specific item

//7.How do you indicate that a class has a generic type parameter?
// By the <T> that appears after the class name

//8.True/False. Generic classes can only have one generic type parameter.
//False

//9.True/False. Generic type constraints limit what can be used for the generic type.
//True

//10.True/False. Constraints let you use the methods of the thing you are constraining to.
//True

//Testing Classes
//1) Stack
Console.WriteLine("Stack:");
MyStack<string> stack = new MyStack<string>();
Console.WriteLine("Stack Size: " + stack.Count());
Console.WriteLine("1st Item");
stack.Push("1st Item");
Console.WriteLine("Stack Size: " + stack.Count());
Console.WriteLine("2nd Item");
stack.Push("2nd Item");
Console.WriteLine("Stack Size: " + stack.Count());
Console.WriteLine("Poping");
Console.WriteLine(stack.Pop());
Console.WriteLine("Stack Size: " + stack.Count());
Console.WriteLine("Poping");
Console.WriteLine(stack.Pop());
Console.WriteLine("Stack Size: " + stack.Count());

//2) List
Console.WriteLine("\nList:");
MyList<int> list = new MyList<int>();
Console.WriteLine("Adding 4");
list.Add(4);
Console.WriteLine($"Does it contain 4? {list.Contains(4)}");
Console.WriteLine("Clearing list");
list.Remove(0);
Console.WriteLine($"Does it contain 4? {list.Contains(4)}");

//3) Generic Repository
Console.WriteLine("\nRepository:");
Console.WriteLine("Create Entitys for Repository:");
Entity entity1 = new Entity(2, "Oranges");
Entity entity2 = new Entity(84);
Entity entity3 = new Entity(618, "Books");
Console.WriteLine("Create Repository and add entries:");
GenericRepository repository = new GenericRepository();
repository.Add(entity1);
repository.Add(entity2);
repository.Add(entity3);
repository.Save();
Console.WriteLine($"Entry with ID #2 has the name: {repository.GetById(2).Name}");
Console.WriteLine("Passing repository");
IEnumerable<Entity> enumerableEntity = repository.GetAll();
Console.WriteLine($"Removing 3rd Entry");
repository.Remove(entity3);
repository.Save();