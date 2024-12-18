// See https://aka.ms/new-console-template for more information
// Task 1
#region
string  Greetuser( string name)

{

    return name;
}


// Task 2 

double volume ( double length , double width, double height)
{
    return length*width*height;
}
// Task 3
double numberf (double number )
{
    if ( number  %2==0 )
    {
        return number * 2;
    }
    else
    {
        return number * number;
    }

}

//task 4

double fahrenheit ( double celsius)
{


    return (celsius * 9 / 5) + 32;
}

//task 6
double currency (double original , double conversion)
{
    return  (original * conversion);

}


#endregion




#region
//task 1
Console.WriteLine("Enter your full name");
string name = Console.ReadLine();
Console.WriteLine("hello " + Greetuser (name));

//task2


Console.WriteLine("enter the length ");
double length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the length ");
double height  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the length ");
double width = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The volume of a box is " + volume(length , width, height));

//taske 3
Console.WriteLine("enter a number");
double number=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("answer is " + numberf(number ));

// task4 


Console.WriteLine("enter temp in celsius");
double celsius = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("in celsius equal" + fahrenheit (celsius));


//task6

Console.WriteLine("enter originla ");
double originla=Convert.ToInt32( Console.ReadLine());
Console.WriteLine("enter conversion");
double conversion = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("coverted amount =" + currency(originla, conversion));

#endregion