public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing MyProperty before it's initialized can lead to unexpected behavior.
        int value = MyProperty; //Bug: Accessing uninitialized property 
        Console.WriteLine(value);
    }
}