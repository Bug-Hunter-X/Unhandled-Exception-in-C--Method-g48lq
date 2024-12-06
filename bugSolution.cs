public class MyClass {
    public int MyMethod(int a, int b) {
        try {
            if (a == 0 || b == 0) {
                return 0; // Handle division by zero
            }
            return a / b;
        } catch (DivideByZeroException ex) {
            Console.WriteLine("Error: Division by zero.");
            return 0; // Or handle the exception as needed.
        }
    }
}