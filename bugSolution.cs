public class MyClass {
    private int _myProperty; // Private backing field

    public int MyProperty {
        get { return _myProperty; }
        set { _myProperty = value; }
    }

    public void MyMethod() {
        // Initialize the property before accessing it.
        MyProperty = 5; 
        Console.WriteLine(MyProperty); // This will consistently print 5.
    }
}