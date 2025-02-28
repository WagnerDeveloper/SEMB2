//Counter
for(var i=1; i<=10; i++){
    Console.WriteLine(i);
}

string[] favoriteGames = ["Minecraft", "GTA", "Battlefield"];


for(var i=0; i < favoriteGames.Length ; i++){
    Console.WriteLine(favoriteGames[i]);
} 

foreach(var i in favoriteGames){
    Console.WriteLine(i);
}

favoriteGames.ToList().ForEach((i) => {
    Console.WriteLine(i);
});

Array.ForEach(favoriteGames, (i) => Console.WriteLine(i));



