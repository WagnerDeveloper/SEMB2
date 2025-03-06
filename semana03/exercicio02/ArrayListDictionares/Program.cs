int[] myarray = new int[100];

string[] array = new string[7];
array[0] = "Sunday";
array[1] = "Monday";
array[2] = "Tuesday";
array[3] = "Wednesday";
array[4] = "Thursday";
array[5] = "Friday";
array[6] = "Saturday";

for (int i = 0; i < array.Length; i++) {
    Console.WriteLine(array[i]);
}

List<string> list = new List<string>();
list.Add("Sunday");
list.Add("Monday");
list.Add("Tuesday");
list.Add("Wednesday");
list.Add("Thursday");
list.Add("Friday");
list.Add("Saturday");

for (int i = 0; i < list.Count; i++)
{
    list[i] = list[i].Substring(0, 3);
    Console.WriteLine(list[i]);
}

Dictionary<string, int> dictionary = new Dictionary<string, int>();
dictionary.Add("Sunday", 1);
dictionary.Add("Monday", 2);
dictionary.Add("Tuesday", 3);
dictionary.Add("Wednesday", 4);
dictionary.Add("Thursday", 5);
dictionary.Add("Friday", 6);
dictionary.Add("Saturday", 7);

for (int i = 0; i < dictionary.Count; i++)
{
    Console.WriteLine(dictionary.ElementAt(i).Key + " " + dictionary.ElementAt(i).Value);
}



