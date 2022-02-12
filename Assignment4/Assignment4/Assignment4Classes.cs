using System;
//Practice working with Generics

//1) Stack class
public class MyStack<T>
{
	//Field
	private List<T> stackList = new List<T>();
	private int position = 0;

	//Methods
	//Counting the stack
	public int Count()
    {
		return stackList.Count;
    }
	//Pop stack
	public T Pop()
    {
		T item = stackList[position];
		stackList.RemoveAt(position);
		return item;
    }
	//Push stack
	public void Push()
    {

    }
}

//2) 
public class MyList<T>
{
	//Field

	//Method

}

//3)
public interface IRepository<T>
{
	void Add(T item);
	void Remove(T item);
	void Save();
	IEnumerable<T> GetAll();
	T GetById(int id);
}

public class GenericRepository<T>: IRepository<T>
{
	//Field

	//Methods

}