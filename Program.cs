// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Globalization;
using System.Security.AccessControl;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("CurrentCulture is now {0}.", CultureInfo.CurrentCulture.Name);

        // Task 7 Car Plates

        ////Write a program that holds an information about cars entering and leaving the parking. The functionality we want is:
        //No car can enter the parking 2 times without leaving
        //On every entrance you will receive number plate
        //On every exit you will receive number plate and number of hours (CB 11111 AA,2.5)
        //Your task is to calculate the price per stay of every car (first hour is free, after that every hour 1.50 lv, after 6-th hour every hour is 3lv)
        //If a car tries to enter second time without leaving, or leave without enter print the message (“Invalid number plate”)
        //Also the parking will have some special guests which are not paying for the stay, their number plates are (CB 11111 AA), (B BBBB B), (CB 7777 CB)

        Dictionary<string, double> carsInParking = new Dictionary<string, double>();

        string inputInfo = "";


        while (inputInfo != "end")
        {
            inputInfo = Console.ReadLine();
            string[] plateInfo = inputInfo.Split(',');
            string plate = plateInfo[0];
            double price = 0;


            //Check if plateInfo is only 1 substring(e.g. ENTER);
            if (plateInfo.Length == 1)
            {
                //  If YES: check if plate is contains in carsInParking

                if (carsInParking.ContainsKey(plate))
                {
                    //If YES:  car tries to enter second time without leaving - print msg
                    Console.WriteLine("Invalid number plate! The car is allready in the parking!");
                }
                else
                {
                    //      If NO:  put plate in carsInParking as a KEY
                    carsInParking.Add(plate, 0);
                }
            }
            else
            {
                //  If NO (e.g. EXIT): check if plate is in the carsInParking as a KEY
                if (carsInParking.ContainsKey(plate))
                {
                    //          If YES calculate price and remove as a KEY
                    Console.WriteLine(plateInfo[0]);
                    Console.WriteLine(plateInfo[1]);
                    //double time = Double.Parse("2,5");

                    //double time = Double.Parse(plateInfo[1].Replace(".", ","));
                    double time = Double.Parse(plateInfo[1], CultureInfo.InvariantCulture);
                    price = CalculatePrice(time);
                    Console.WriteLine(price);
                    carsInParking.Remove(plate);
                }
                else
                {
                    //          If NO car tries to leave without enter - print msg
                    Console.WriteLine("Invalid number plate! Such car was not ENTER");

                }


            }

        }



        //Console.WriteLine(plateInfo[0]);
        //Console.WriteLine(plateInfo[1]);
    }

    private static double CalculatePrice(double time)
    {
        double result = 0;
        if (time > 6)
        {
            result = (5) * 1.5 + (time - 6) * 3;
        }
        else
        {
            result = (time - 1) * 1.5;
        }

        return result;
    }
}