using System;
using System.Collections.Generic;
using System.Linq;
class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        // Create a list of Person objects with different properties
        List<Person> people = new List<Person>
        {
            new Person { FirstName = "ANJALI", LastName = "KOTHARI", Age = 22 },
            new Person { FirstName = "PRIYANKA", LastName = "PARMAR", Age = 23 },
            new Person { FirstName = "NIKEETA", LastName = "PATEL", Age = 30 },
             new Person { FirstName = "URVASHI", LastName = "PARMAR", Age = 16 }
        };
        var filteredPeople = people.Where(p => p.Age >= 18)
                                   .OrderBy(p => p.LastName)
                                   .ThenBy(p => p.FirstName);
        // Print the filtered and sorted list of people to the console
        foreach (var person in filteredPeople)
        {
            Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}");
        }
    }
}