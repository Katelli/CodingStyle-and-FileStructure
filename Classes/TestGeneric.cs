public class TestGeneric : ITestGeneric
{
    public Generic? genericType;
    public GenericList genericListType;
    
    // Constructor to initialize with Generic and List data
    public TestGeneric(Generic? generic)
    {
        genericType = generic;
        genericListType = new GenericList();
        // Add the current TestGeneric instance to the list
        genericListType.Add(this);
    }

    // Default constructor
    public TestGeneric()
    {
        genericListType = new GenericList();
    }

    /* 
    Method to print the contents of the generic list
    It's set to print out each instance of ID and SomeText in TestGeneric
    */
    public void PrintGeneric()
    {
        var genericList = genericListType.GetData<TestGeneric>();
        foreach(var item in genericList)
        {
            if(item.genericType != null)
            {
                Console.WriteLine($"ID: {item.genericType.ID} Text: {item.genericType.SomeText}");
            }
        }
    }
}