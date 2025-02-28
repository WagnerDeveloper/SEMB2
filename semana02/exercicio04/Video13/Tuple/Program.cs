var values = ("M", 2, "T");

Console.WriteLine(values.Item1);
Console.WriteLine(values.Item2);
Console.WriteLine(values.Item3);

var valuesWithName = (First: "M", Second: 2, Third: "T");

Console.WriteLine(valuesWithName.First);
Console.WriteLine(valuesWithName.Second);
Console.WriteLine(valuesWithName.Third);


(int a, string b, bool c) ReturnTheseValues(){
    return (5, "M", true);
}

var tupleReturnValue = ReturnTheseValues();

Console.WriteLine(tupleReturnValue.a);
Console.WriteLine(tupleReturnValue.Item2);
Console.WriteLine(tupleReturnValue.c);