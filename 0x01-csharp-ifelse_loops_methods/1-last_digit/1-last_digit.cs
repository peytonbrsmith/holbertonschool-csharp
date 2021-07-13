using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
	// get last digit of number
    int lastDigit = number % 10;
    string condition = "";
    

    // if the last digit is greater than 5 set condition to "and is greater than 5"
    if (lastDigit > 5)
    {
        condition = "and is greater than 5";
    }
    // if the last digit is less than 6 and not 0 set condition to "and is less than 6"
    else if (lastDigit < 6 && lastDigit != 0)
    {
        condition = "and is less than 6 and not 0";
    }
    // if the last digit is 0 set condition to "and is 0"
    else if (lastDigit == 0)
    {
        condition = "and is 0";
    }    

    // print "The last digit of number is"
    Console.WriteLine("The last digit of {0} is {1} {2}", number, lastDigit, condition);
    }
}