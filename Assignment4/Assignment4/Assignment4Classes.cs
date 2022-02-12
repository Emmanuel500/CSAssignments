using System;

//Practice working with Generics

//1) Stack class
public class MyStack<T>
{
	//Field
	private List<T> stackList = new List<T>();

	//Methods
	//Counting the stack
	public int Count()
    {
		return stackList.Count;
    }
	//Pop stack
	public T Pop()
    {
		T item = stackList[stackList.Count - 1];
		stackList.RemoveAt(stackList.Count - 1);
		return item;
    }
	//Push stack
	public void Push(T additem)
    {
		stackList.Add(additem);
	}
}

//2) List class
public class MyList<T>
{
	//Field
	private List<T> myList = new List<T>();

	//Method
	public void Add (T element)
	{
		myList.Add(element);
	}
	public T Remove (int index)
	{
		T item = myList[index];
		myList.RemoveAt(index);
		return item;
	}
	public bool Contains (T element)
	{
		try
        {
			return myList.Contains(element);
        }
		catch (NullReferenceException e){ return false; }
	}
	public void Clear ()
	{
		myList.Clear();
	}
	public void InsertAt (T element, int index)
	{
		myList.Insert(index, element);
	}
	public void DeleteAt (int index)
	{
		myList.RemoveAt(index);
	}
	public T Find (int index)
	{
		return myList[index];
	}
}


//3) Entity Repository
public class Entity
{
	//Field
	private int id;
	private string name;
	//Constructor
	public Entity(int entryId, string entryName = "")
    {
		id = entryId;
		name = entryName;
    }
	//Property
	public int Id { get { return id; } set { id = value; } }
	public string Name { get { return name; } set { name = value; } }
}
public interface IRepository<T> where T : class
{
	void Add(T item);
	void Remove(T item);
	void Save();
	IEnumerable<T> GetAll();
	T GetById(int id);
}
public class GenericRepository: IRepository<Entity>
{
	//Field
	private List<Entity> repositoryStorage = new List<Entity>();
	private bool saved = true;

	//Methods
	public void Add(Entity item)
    {
		repositoryStorage.Add(item);
		saved = false;
	}
	public void Remove(Entity item)
    {
		repositoryStorage.Remove(item);
		saved = false;
	}
	public void Save()
    {
		saved = true;
    }
	public IEnumerable<Entity> GetAll()
    {
		return repositoryStorage;
    }
	public Entity GetById(int id)
    {
		for (int x = 0; x < repositoryStorage.Count; x++)
        {
			if (repositoryStorage[x].Id == id)
            {
				return repositoryStorage[x];
            }
        }
		return null;
    }
}