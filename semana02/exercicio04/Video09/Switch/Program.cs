var solarSystemPlanet = "Jupyter";

switch (solarSystemPlanet)
{
    case "Saturn":
        Console.WriteLine("Saturn");
        break;
    case "Jupyter":
        Console.WriteLine("Jupyter");
        break;
    default:
        Console.WriteLine("Sun");
        break;
}

var result = solarSystemPlanet switch{
    "Saturn" => "Saturn",
    "Jupyter" => "Jupyter",
    _ => "Sun"
};

Console.WriteLine("That is " + result);