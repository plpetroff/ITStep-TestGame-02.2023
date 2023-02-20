// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Security.AccessControl;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Task 7 Car Plates

        ////Write a program that holds an information about cars entering and leaving the parking. The functionality we want is:
        //No car can enter the parking 2 times without leaving
        //On every entrance you will receive number plate
        //On every exit you will receive number plate and number of hours (CB 11111 AA,2.5)
        //Your task is to calculate the price per stay of every car (first hour is free, after that every hour 1.50 lv, after 6-th hour every hour is 3lv)
        //If a car tries to enter second time without leaving, or leave without enter print the message (“Invalid number plate”)
        //Also the parking will have some special guests which are not paying for the stay, their number plates are (CB 11111 AA), (B BBBB B), (CB 7777 CB)

        Dictionary<string, double> carsInParking = new Dictionary<string, double>();

        string inputInfo = Console.ReadLine();
        string[] plateInfo = inputInfo.Split(',');

        //Check if plateInfo is only 1 substring;
        if (plateInfo.Length == 1)
        {
            //  If YES: check if plate is contains in carsInParking
            string plate = plateInfo[0];
            if (carsInParking.ContainsKey(plate))
            {
                //If YES:  car tries to enter second time without leaving - print msg
            }
            else
            {
                //      If NO:  put plate in carsInParking as a KEY
            }
        }
        else
        {
            //  If NO: check if plate is in the carsInParking as a KEY
            if (true)
            {
                //          If YES calculate price and remove as a KEY
            }
            else
            {
                //          If NO car tries to leave without enter - print msg
            }


        }


        
         
        
        
        
        



        Console.WriteLine(plateInfo[0]);
        Console.WriteLine(plateInfo[1]);
    }
}