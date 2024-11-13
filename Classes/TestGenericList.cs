using System.IO.Pipelines;

public class TestGenericList : ITestGeneric
{
    public Test? testType;
    public GenericList genericListType;
    public TestGenericList(Test? test)
    {
        testType = test;
        genericListType = new GenericList();
        genericListType.Add(this);
    }

    public TestGenericList()
    {
        genericListType = new GenericList();
    }

    public void PrintGeneric()
    {
        var genericList = genericListType.GetData<TestGenericList>();
        foreach(var item in genericList)
        {
            if(item.testType != null)
            {
                Console.WriteLine($"ID: {item.testType.ID} Text: {item.testType.SomeText}");
            }
        }
    }
}