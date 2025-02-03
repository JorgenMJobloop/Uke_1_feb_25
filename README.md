# Conventions
    - Classes use PascalCase
    - On fields we use camelCase
    - For SQL Queries, prefer to use LINQ
    - Docstrings: ///<information about classes, fields, properties and methods>///
```cs
    /// <summary>
    /// Prints out Hello World
    /// </summary>
public void DocstringExample() 
{
    Console.WriteLine("Hello, World!");
}

```

# Generic Classes
    - We can create our own "generic" classes
    - Generic classes can extend primitive types, or function as their own datatypes


# Generic Types
    - Flexible and dynamic, can be determined on initialization of new objects
    - example 
```cs
    class Generic<T>
    {
        private T genericField;

        public void SetValue(T value) 
        {
            value = genericField;
        }

        public void PrintFieldValue() 
        {
            Console.WriteLine($"{genericField}");
        }
    } 
    
    Generic<int> generic = new Generic<int>(); // assignment of a new object that that hold integers
    generic.SetValue(5);
    generic.PrintFieldValue(); // output: 5
```
