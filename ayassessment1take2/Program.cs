//method 1
static bool IsPassing(double grade)
{
    if (grade >= 66.0)
    {
        return true;
    }
    if (grade <= 65.0) ;
    {
        return false;
    }
}

//test code method1
Console.WriteLine(IsPassing(67.0)); //true
Console.WriteLine(IsPassing(47.0)); //false

//method2
static double AverageGrades(double grade1, double grade2, double grade3)
{
    return (grade1 + grade2 + grade3) / 3;
}

Console.WriteLine(AverageGrades(50.0, 50.0, 50.0)); //test code method2 should return 50

//method3
static string OddOrEvenAndPassing(double grade)
{
    if (grade >= 66.0 && grade % 2 != 0)
    {
        return "passing and odd";
    }
    if (grade <= 65.0 && grade % 2 != 0)
    {
        return "failing and odd";
    }
    if (grade >= 66.0 && grade % 2 == 0)
    {
        return "passing and even";
    }
    if (grade <= 65.0 && grade % 2 == 0)
    {
        return "failing and even";
    }
    return ""; //as to fix the dreaded CS0161 error
}
//test code method3
Console.WriteLine(OddOrEvenAndPassing(69.0)); //passodd
Console.WriteLine(OddOrEvenAndPassing(49.0)); //failodd
Console.WriteLine(OddOrEvenAndPassing(80.0)); //passeven
Console.WriteLine(OddOrEvenAndPassing(44.0)); //faileven