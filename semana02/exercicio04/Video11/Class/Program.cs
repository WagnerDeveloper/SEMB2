using Class;

//CRUD

Pokemon poke = new Pokemon();
Pokemon pokesh = new Pokemon();

poke.name = "Pikachu";
poke.id = 10;
poke.isShiny = false;

pokesh.name = "Mewtwo";
pokesh.id = 251;
pokesh.isShiny = true;

//READ
Console.WriteLine(poke.name + " " + poke.id + " " + poke.isShiny);
Console.WriteLine(pokesh.name + " " + pokesh.id + " " + pokesh.isShiny);

//UPDATE
poke.id = 11;
pokesh.id = 252;

Console.WriteLine(poke.id);
Console.WriteLine(pokesh.id);

//DELETE
poke.name = "";
pokesh.name = "";

Console.WriteLine(poke.name);
Console.WriteLine(pokesh.name);