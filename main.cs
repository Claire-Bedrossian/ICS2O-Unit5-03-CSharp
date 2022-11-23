// Created by: Claire Bedrossian
// Created on: Nov 2022
//
// This program is a game to guess a random number the computer has generated.

using System;

class Program
{
    public static void Main(string[] args)
    {
        System.Random random = new System.Random();

 // This function accepts user input.

double age;
        
        Console.WriteLine(" This program will tell you what movies you may watch. Please enter your age below...");
        Console.WriteLine("");

        Console.Write("Enter your age: ");
        age = Convert.ToDouble(Console.ReadLine());

        if (age >= 17)
        {
            Console.WriteLine("You may see an R rated movie alone.");
        }
        else if (age >= 13)
        {
            Console.WriteLine("You may see a PG-13 movie alone.");
        }
        else if (age >= 5)
        {
            Console.WriteLine("You may see a G or PG movie alone.");
        }
        else    
        {
            Console.WriteLine("You probably shouldn't see a movie alone.");
        }
        Console.WriteLine("");
        Console.WriteLine("\nDone.");
    }
}