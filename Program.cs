// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Security.AccessControl;

Console.WriteLine("Hello, World!");

// Task 8

string pass = Console.ReadLine();

//Write a program that checks if a given password is valid. Password rules are:
//6 – 36 characters(inclusive)
//Consists only of letters, digits and special symbols
//Have at least 2 digits, 1 special symbol, 1 upper case, 1 lower case
//If a password is valid print "Password is valid". If it is not valid, for every unfulfilled rule print an appropriate message

ValidatePassword(pass);

void ValidatePassword(string arg)
{
    //ValidateLength(arg);
    if (!ValidateLength(arg))
    {
        Console.WriteLine("Password Length must be between 2 and 12 characters!");
    }
    else if(!ValidateLetterSimbolsDigit(arg))
    {
        Console.WriteLine("Pasword must contain only letters, digits and symbols!");
    }
    else if (!ValidateAtLeas2Digits1SpecialSymbol1UpperCase1LowerCase(arg))
    {
        Console.WriteLine("Password must have at least 2 digits, 1 special symbol, 1 upper case, 1 lower case");
    }
    else 
    {
        Console.WriteLine("Password is valid");
    }


    //ValidateLetterSimbolsDigit(arg);
    

    //ValidateAtLeas2Digits1SpecialSymbol1UpperCase1LowerCase(arg);
    

}

bool ValidateAtLeas2Digits1SpecialSymbol1UpperCase1LowerCase(string arg)
{
    bool flag = false;
    int countOfDigits = 0;
    int countOfSpecial = 0;
    int countOfUpperCase = 0;
    int countOfLowerCase = 0;

    for (int i = 0; i < arg.Length; i++)
    {
        if (48 <= arg[i] && arg[i] <= 57)
        {
            countOfDigits++;

        }
        else if( (33 <= arg[i] && arg[i] <= 47) || 
                 (58 <= arg[i] && arg[i] <= 64) ||
                 (91 <= arg[i] && arg[i] <= 96) ||
                 (123 <= arg[i] && arg[i] <= 126)  )
        {
            countOfSpecial++;
        }
        else if(65 <= arg[i] && arg[i] <= 90)
        {
            countOfUpperCase++;
        }
        else if(97 <= arg[i] && arg[i] <= 122)
        {
            countOfLowerCase++;
        }


    }

    if (countOfDigits >=2 && countOfSpecial >=1 && countOfUpperCase >= 1 && countOfLowerCase >=1)
    {
        flag = true;
    }


    return flag;

}

bool ValidateLetterSimbolsDigit(string arg)
{
    bool flag = false;
    for (int i = 0; i < arg.Length; i++)
    {
        if (33 <= arg[i] && arg[i] <= 126)
        {
            flag = true;
        }
        else
        {
            flag = false;
            break;
        }

    }
    return flag;
}

bool ValidateLength(string arg)
{
    if (2 <= arg.Length && arg.Length <= 12)
    {
        return true;
    }
    return false;
}

Console.WriteLine(pass);



