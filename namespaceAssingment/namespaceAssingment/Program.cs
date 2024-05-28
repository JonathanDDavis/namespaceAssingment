using System;

namespace namespaceAssingment
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "John";
            person.Age = 28;
            person.HasPet = true;

            person.Greeting();
            person.newPerson();
        }
    }
}
