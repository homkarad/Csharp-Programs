using System;
public class Address
{
    public string addressLine, city, state;
    public Address(string addressLine, string city, string state)
    {
        this.addressLine = addressLine;
        this.city = city;
        this.state = state;
    }
}
public class Employee
{
    public int id;
    public string name;
    public Address address;//Employee HAS-A Address  
    public Employee(int id, string name, Address address)
    {
        this.id = id;
        this.name = name;
        this.address = address;
    }
    public void display()
    {
        Console.WriteLine(id + " " + name + " " +
          address.addressLine + " " + address.city + " " + address.state);
    }
}
public class TestAggregation
{
    public static void Main(string[] args)
    {
        Address a1 = new Address("Rajaramnagar, Sakharale", "Islampur", "Sangli");
        Employee e1 = new Employee(1, "Akshay Homkar", a1);
        e1.display();
    }
}