﻿//main

DisplayMenu();
int userChoice = GetMenuChoice();
Console.WriteLine(userChoice);
RouteEm(userChoice);

//end
static void DisplayMenu()
{
    Console.WriteLine("1. Plain Pizza\n2. Cheese Pizza\n3. Pepperoni Pizza ");
}

static int GetMenuChoice()
{
    Console.WriteLine("Enter your menu choice: ");
    return int.Parse(Console.ReadLine());
}
static void RouteEm(int userChoice)
{
    if (userChoice == 1)
    {
        PlainPizza();
        Pause();
    }
    else if (userChoice == 2)
    {
       CheesePizza();
       Pause();
    }
    else if (userChoice == 3)
    {
        PepPizza();
        Pause();
    }
    else if (userChoice == 4)
    {
        Console.WriteLine("Exit");
    }
    else 
    {
        Console.WriteLine("You made an invalid choice");
        Pause();
    }
    static void Pause()
    {
        Console.WriteLine("Press any key to view menu options");
        Console.ReadKey();
        Console.Clear();
        DisplayMenu();
        int newChoice = GetMenuChoice();
        RouteEm(newChoice);
    }
    static void PlainPizza()
    {
        //random generator
        Random rnd = new Random();
        //structure rows from 8-12
        int rows = rnd.Next(8,13);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows - i; j++)
            {
                Console.Write("*   ");
            }
            Console.WriteLine();
        }

    }
    static void CheesePizza()
    {
        //random generator
        Random rnd = new Random();
        //structure rows from 8-12
        int rows = rnd.Next(8,13);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows - i; j++)
            {
                if (i == 0)
                {
                    Console.Write("*   ");
                }
                else if (j == 0 || j == rows - i - 1)
                { 
                    Console.Write("*   ");
                }
                else
                {
                    Console.Write("#   ");
                }
            }
            Console.WriteLine();
        }
    }
    static void PepPizza()
    {
        //random generator
        Random rnd = new Random();
        //structure rows from 8-12
        int rows = rnd.Next(8,13);
        int number = rnd.Next(2);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows - i; j++)
            {
                if (i == 0)
                {
                    Console.Write("*   ");
                }
                else if(j == 0 || j == rows - i - 1)
                {
                    Console.Write("*   ");
                }
             
                else if (number == rnd.Next(2) )
                {
                    Console.Write("[]  ");
                }
                else 
                {
                    Console.Write("#   ");
                }
            }
            Console.WriteLine();
        }
    }
}

    


