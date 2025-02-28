//CRUD
//CREATE
List<int> numNums = [1, 2, 3, 4, 5];

//READ
foreach(var num in numNums){
    Console.WriteLine(num);
};

//UPDATE
numNums.Add(0);
//insert
numNums.Insert(0,0);
foreach(var num in numNums){
    Console.WriteLine(num);
};

//DELETE
var newNum = numNums.Where((i) => i != 2);

foreach(var num in newNum){
    Console.WriteLine(num);
}

numNums.Remove(1);
numNums.RemoveAt(0);

foreach(var num in numNums){
    Console.WriteLine(num);
}