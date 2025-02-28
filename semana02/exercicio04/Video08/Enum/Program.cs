Console.WriteLine((int)Warning.CodeYellow);

var status = Warning.CodeYellow;

if(status == Warning.CodeYellow){
    Console.WriteLine((int)Warning.CodeYellow + "CODE YELLOW!");
}
enum Warning
{
    CodeRed,
    CodeBlue,
    CodeYellow
}
