namespace CodingStyle_and_FileStructure;

class Program
{
    static void Main(string[] args)
    {
        Generic generic = new Generic()
        {
            ID = 2,
            SomeText = "Something"
        };
        
        TestGeneric testGeneric = new TestGeneric(generic);
        testGeneric.PrintGeneric();
        
        Test test = new Test()
        {
            ID = 3,
            SomeText = "Hello There"
        };
        TestGenericList testGenericList = new TestGenericList(test);
        testGenericList.PrintGeneric();
    }
}
