Person person1 = new("Marco Tulio", "Vilela Fonseca", new string[1] { "34984425668" });
Person person2 = new("Marco Tulio", "Vilela Fonseca", new string[1] { "34984425668" });

//person1.LastName = "Moura";
person1.PhoneNumbers[0] = "34992278940";

Console.WriteLine(person1 == person2);

Person person3 = person2 with { LastName = "Moura" };
Console.WriteLine(person3.ToString());

public record Person(string FirstName, string LastName, string[] PhoneNumbers);