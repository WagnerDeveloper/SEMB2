//Array CRUD

//CREATE
string[] favoritePokemon = ["Charizard", "Pikachu", "Gengar", "Dragonite", "Zapdos"];

//READ
//Console.WriteLine(favoritePokemon[]);
foreach (var i in favoritePokemon){
    Console.WriteLine(i);
}

//UPDATE
favoritePokemon[0] = "Squirtle";
foreach (var i in favoritePokemon){
    Console.WriteLine(i);
}   

//DELETE
