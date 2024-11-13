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
    // List to hold generic items, allow nullable references
    private List<object?> lists = new List<object?>();

    // Method to get data of type T
    public List<T> GetData<T>()
    {
        List<T> genericList = new List<T>();

        // Add items of type T to the genericList
        foreach(var item in lists)
        {
            if(item is T FieldVariable)
            {
                genericList.Add(FieldVariable);
            }
        }

        return genericList;
    }

    // Method to add an item to the internal list 
    public void Add<T>(T item)
    {
        lists.Add(item);
    }
}
