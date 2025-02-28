using Methods;

RealState street = new()
{
    Address = "Elm Street",
    SquareFootage = 1500,
    Price = 150000
};

Console.WriteLine(street.CalculatePricePerSquareFoot());