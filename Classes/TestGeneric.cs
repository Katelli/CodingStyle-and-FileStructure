public class TestGeneric : ITestGeneric
{
    public Generic? genericType;
    public GenericList genericListType;
    public TestGeneric(Generic? generic)
    {
        genericType = generic;
        genericListType = new GenericList();
        genericListType.Add(this);
    }

    public TestGeneric()
    {
        genericListType = new GenericList();
    }

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