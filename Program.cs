// ISM 4300 T3 Assignment - submitted by Uliana Tretyakova
//This program displays a conversion table that compares CAD to USD values based on entered increment value.

//Ask a user to enter CAD increment value
Console.WriteLine("Please enter CAD increment value between 5 and 25:");

//Use try catch method to confirm a valid input
try
{
    //Declare variables
    string inputData = Console.ReadLine();
    int incValue = int.Parse(inputData);
    int cad = 0;
    decimal usd = 1.00m;

    //Confirm that input value is in a given range 
    if (incValue >= 5 && incValue <= 25)
    {
        Console.WriteLine("CAD Increment Value = " + incValue);
        Console.WriteLine(""); //Insert a blank line
        Console.WriteLine("CAD                 US$");
        Console.WriteLine(""); //Insert a blank line
        Console.WriteLine(cad.ToString("n2") + "               0.00");

        //Calculate CAD and USD values and display them in a table
        while (cad < 200)
        {
            cad = cad + incValue;  //Calculate CADs to display based on entered CAD increment
            usd = cad * 0.792367m; //Convert CADs to US$
            
            //Exit loop if value of CAD exceeds 200
            if (cad > 200) 
                break;

            //Display each line of a table
            Console.WriteLine(cad.ToString("n2") + "              " + usd.ToString("n2")); 
        }
    }

    else
    {
        //Display an error message for invalid input
        Console.WriteLine("Please restart the program and only enter whole numbers between 5 and 25.");
        Console.WriteLine("Press any key to exit the program.");
        Console.ReadKey(true);
    }
}

catch 
{
    //Display an error message for invalid input
    Console.WriteLine("Please restart the program and only enter whole numbers between 5 and 25.");
    Console.WriteLine("Press any key to exit the program.");
    Console.ReadKey(true);
}