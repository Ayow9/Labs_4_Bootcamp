//SEE "C#Mega Review" for more info
//Declare varibles
using System.ComponentModel;

int age = 25;
string name = "john doe";
bool isStundet = true;
double price = 19.99;
char grade = 'a'; //remember char is 'x' not "x"
//varible types
float tempeture = 36.6f; //always put an f after ya float varible
long distance = 9876543210;
decimal balance = 1000.50m; //m after ya decimal varible
byte level = 3;

//IF STATEMENTS
if (age >= 18)
{ Console.WriteLine("Adult age"); }

if (name != "") ;
{ Console.WriteLine($"Welcome {name}!"); }

if (isStundet == true)
{ Console.WriteLine("Free Access my dood!"); }

//SWITCH STATEMENTS
switch (age)
{
    case > 12 and < 18:
        Console.WriteLine("Child");
        break;
    case >= 18 and < 65: //its range between 18 to 65
        Console.WriteLine("Adult");
        break;
    case > 65:
        Console.WriteLine("Senior");
        break;
}

switch (name)
{
    case "John Doe":
        Console.WriteLine("Hi John!");
        break;
    case "Jane Doe":
        Console.WriteLine("Hi Jane!");
        break;
}

switch (isStundet)
{
    case true:
        Console.WriteLine("student");
        break;
    case false:
        Console.WriteLine("Not Student");
        break;
    default:
        Console.WriteLine("Whomst??");
        break;
}
//FOR LOOPS

for (int i = 1; i <= 10; i++) //countup
{
    Console.WriteLine(i);
}

for (int j = 10; j >= 10; j--) //countdown
{
    Console.WriteLine(j);
}
//#2 from review doc in FOR LOOPS
foreach (var letter in name)
{
    Console.WriteLine(letter);
}

//#3 Print student 5 times if isStudent == true
if (isStundet == true)
{
    for (int i = 0; i < 5; i++)
    { Console.WriteLine(isStundet); }
}

//WHILE LOOPS
int count = 0;
while (count < 10)
{
Console.WriteLine(count);
    count++;
}

//#3 
decimal price2 = 60m;
while (price2 >= 10m)
{
    Console.WriteLine(price2);
    price2--;
}
//DO WHILE LOOPS
//#3
double price3 = 10;
do
{
    Console.WriteLine(price3);
    price3 -= 1.0;
}
while (price3 >= 9);

//DICTIONARIES
//VV example below VV
Dictionary<string, int> exampleDict = new Dictionary<string, int>();

exampleDict.Add("The", 1);
exampleDict.Add("Dig", 2);
exampleDict.Add("Dug", 3);
//looping thru dictionary

foreach (string key in exampleDict.Keys) 
{
    Console.WriteLine($"{key}");
}

//#1
Dictionary<string, double> GradeBook = new Dictionary<string, double>();
GradeBook.Add("John", 47.5);
GradeBook.Add("Potato Man", 67.5);
GradeBook.Add("Johanna", 99.9);

Console.WriteLine("Whats ur nmae?");
double grade2 = double.Parse(Console.ReadLine());

string Student = Console.ReadLine();

if (GradeBook.ContainsKey(Student))
{
    Console.WriteLine($"{GradeBook[Student]}");
}

//LISTS 
List<int> numbers = new List<int>()
{1,2,3,4,5,6,7,8,9,10};
//OR
List<int> numbers2 = new List<int>();
