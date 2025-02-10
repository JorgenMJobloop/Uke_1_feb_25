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
        // filepath the name of our file in the working directory
        createTextFile.CreateNewFile("new_text.txt");
        createTextFile.WriteContent("new_text.txt", "This is my text content");
        createTextFile.ReadBytes("Csharp_copy.png");
        GenericMethods genericMethods = new GenericMethods();
        genericMethods.Add<double>(2, 3);
        double[] values = { 1, 2, 3, 4 };
        string[] stringValues = { "Hello", "C#", "Strings!" };
        Console.WriteLine(genericMethods.AddRange(values));
        genericMethods.PrintValues(stringValues);
        genericMethods.Concat("Hello", "World!");


        CustomGeneric<int, string, int> customGeneric = new CustomGeneric<int, string, int>();

    }
}
