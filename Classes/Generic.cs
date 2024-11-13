using System.Dynamic;

public class Generic
{
    public Generic? Value;
    public int ID;
    public string? SomeText;
}

public class Test
{
    public Test? Value;
    public int ID;
    public string? SomeText;
}

public class GenericList
{
    private List<object?> lists = new List<object?>();

    public List<T> GetData<T>()
    {
        List<T> genericList = new List<T>();

        foreach(var item in lists)
        {
            if(item is T variable)
            {
                genericList.Add(variable);
            }
        }

        return genericList;
    }

    public void Add<T>(T item)
    {
        lists.Add(item);
    }
}
