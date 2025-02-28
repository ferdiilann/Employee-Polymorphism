using System;

// Defining the IQuittable interface. This interface contains the Quit() method.
public interface IQuittable
{
    // Defining the Quit method. This method must be implemented by classes that implement this interface.
    void Quit();
}

// Person class is defined as a base class.
public class Person
{
    // Defining the FirstName property.
    public string FirstName { get; set; }
    
    // Defining the LastName property.
    public string LastName { get; set; }

    // Constructor for the Person class.
    public Person(string firstName, string lastName)
    {
        // Values from parameters are assigned to the class properties.
        FirstName = firstName;
        LastName = lastName;
    }

    // SayName method prints the person's full name.
    public void SayName()
    {
        // The person's full name is printed to the console.
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}

// Employee class inherits from Person class and implements the IQuittable interface.
public class Employee : Person, IQuittable
{
    // Defining the Id property.
    public int Id { get; set; }

    // Constructor for the Employee class.
    public Employee(string firstName, string lastName, int id) : base(firstName, lastName)
    {
        // Assigning the Id value.
        Id = id;
    }

    // Implementation of the Quit method from the IQuittable interface.
    public void Quit()
    {
        // Printing a message indicating that the employee has quit.
        Console.WriteLine($"{FirstName} {LastName} (ID: {Id}) has quit the job.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Printing the title of the console application.
        Console.WriteLine("IQuittable Interface Implementation");
        Console.WriteLine("----------------------------------");

        // Creating an object from the Employee class.
        Employee employee = new Employee("John", "Smith", 12345);
        
        // Printing the employee's name.
        employee.SayName();
        
        // Calling the Quit method on the employee object.
        employee.Quit();

        Console.WriteLine();
        
        // Using polymorphism to create an object of type IQuittable.
        // This object is actually an Employee object, but of IQuittable interface type.
        IQuittable quittableEmployee = new Employee("Jane", "Doe", 67890);
        
        // Calling the Quit method through the IQuittable interface.
        // This is an example of polymorphism - we can call a method of a class
        // through an interface type object that implements that interface.
        quittableEmployee.Quit();

        // Waiting for the user to press a key before exiting the program.
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
} 