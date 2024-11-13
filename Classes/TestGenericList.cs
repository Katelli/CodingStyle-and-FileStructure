using System.IO.Pipelines;

public class TestGenericList : ITestGeneric
{
    public Test? testType;
    public GenericList genericListType;

    // Constructor to initialize with Test and List data
    public TestGenericList(Test? test)
    {
        testType = test;
        genericListType = new GenericList();
        // Add the current TestGenericList instance to the list
        genericListType.Add(this);
    }

    // Default constructor
    public TestGenericList()
    {
        genericListType = new GenericList();
    }

    /* 
    Method to print the contents of the generic list
    It's set to print out each instance of ID and SomeText in TestGenericList
    */
    public void PrintGeneric()
    {
        var genericList = genericListType.GetData<TestGenericList>();
        foreach(var item in genericList)
        {
            if(item.testType != null)
            {
                Console.WriteLine($"GenericType: {item.testType}. ID: {item.testType.ID}. Text: {item.testType.SomeText}.");
            }
        }
    }
}