public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        MyProperty = 10; // Initialize MyProperty
        int value = MyProperty; 
        Console.WriteLine(value); //Prints 10
    }
}