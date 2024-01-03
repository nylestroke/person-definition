// See https://aka.ms/new-console-template for more information

using OOP1;

Random random = new Random();
DateTime birthday = new DateTime(2007, 8, 24, 13, 15, 00);
var person = new Person("Vladyslav", "Potapenko", birthday, "Male");

Console.WriteLine($" {person.FirstName} {person.LastName} birthday: {person.Birthday} \n " +
    $"Age: {person.GetAge()} \n Sex: {person.Sex}");