using System.Collections;

namespace Uke_1_feb_25;

class Program
{
    static void Main(string[] args)
    {
        GenericStorage<int> genericIntStorage = new GenericStorage<int>();
        genericIntStorage.SetValue(100);
        Console.WriteLine(genericIntStorage.GetValue());

        GenericStorage<string> genericStringStorage = new GenericStorage<string>();

        genericStringStorage.SetValue("Hello");
        Console.WriteLine(genericStringStorage.GetValue());

        Calculator calculator = new Calculator();
        calculator.a = 10;
        calculator.b = -5;
        Console.WriteLine(calculator.Add(3, 9));
        Console.WriteLine(calculator.AddStrict());

        Storage<double> storage = new Storage<double>();
        storage.Set(3.5);
        Console.WriteLine(storage.Get());

        Storage<Test> storage1 = new Storage<Test>();
        Console.WriteLine(storage1);

        CreateTextFile createTextFile = new CreateTextFile();
        createTextFile.CreateNewTextFile("my_text.txt");

        createTextFile.WriteContent("my_text.txt", "Hello C#!");

        // Example List vs ArrayList

        // List<string> strings = new List<string>();
        // strings.Add("Hello");


        // List<object> similiarToArrayList = new List<object>();
        // similiarToArrayList.Add(3);
        // similiarToArrayList.Add("World!");

        // ArrayList arrayList = new ArrayList();
        // arrayList.Add("Hello");
        // arrayList.Add(3);
        // arrayList.Add(null);
    }
}
