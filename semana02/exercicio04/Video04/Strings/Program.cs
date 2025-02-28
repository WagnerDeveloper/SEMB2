// Create Read Update Delete
//CRUD

//CREATE
string initialPokemon = "Squirtle";

//Concactenation
initialPokemon = "The incridible " + initialPokemon;

//Template Literal
Console.WriteLine($"I'll choose {initialPokemon}. You can't stop me!");

Console.WriteLine(initialPokemon);

//READ


//UPDATE
string newPokemon = initialPokemon.Replace("Squirtle", "Charmander");
Console.WriteLine(newPokemon);

//DELETE
//String Builder
System.Text.StringBuilder newLegendary = new System.Text.StringBuilder();
newLegendary.Append("Shiny Mewtwo");
Console.WriteLine(newLegendary);
newLegendary.Remove(0, 6);
Console.WriteLine(newLegendary);