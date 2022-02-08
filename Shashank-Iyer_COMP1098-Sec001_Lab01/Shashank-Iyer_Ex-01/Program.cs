/*
 * Author: Shashank Iyer
 * Student ID: 200488998
 * Course: .NET Programming using C# - 001
 * Date: 28th January, 2022
 * Application: Create four rational objects using two out of three intergers, 
 * select two pairs from the rational object and print them, apply the IncreseBy
 * and DecreseBy methods and print then rational object respectively.
 */

using System;

namespace Shashank_Iyer_Ex_01
{
    internal class Rational
    {
        //Creating two variables numerator and denominator with auto-implemented
        //properties
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        //Creating a public constructor that assigns two arguments to the
        //appropriate fields
        public Rational(int numerator = 0, int denominator = 1)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }


        //Methods
        /*
         * Method that overrides the method of the object class, returns a 
         * string represention of object class
         */
        public override string ToString()
        {
            return String.Format($"\nThe numerator as: {Numerator}\n and the " +
                $"denominator as: {Denominator}\n");
        }

        //Method IncreaseBy() that takes a Rational argument and adds it to the
        //current object but does not output anything 
        public void IncreaseBy(Rational other)
        {
            this.Numerator = (this.Numerator * other.Denominator) + (this.Denominator * other.Numerator);
            this.Denominator = this.Denominator * other.Denominator;
        }

        //Method DecreaseBy() that takes a Rational argument and subtracts it
        //to the current object but does not output anything
        public void DecreaseBy(Rational other)
        {
            this.Numerator = (this.Numerator * other.Denominator) - (this.Denominator * other.Numerator);
            this.Denominator = this.Denominator * other.Denominator;
        }


        //Testing the above Class Rational
        static void Main(string[] args)
        {
            //Creating 4 Rational objects using 0, 1, and 2 arguments.
            Rational rationalObjectOne = new Rational(); //Rational object with 0 arguments.
            Rational rationalObjectTwo = new Rational(4); //Rational object with 1 argument.
            Rational rationalObjectThree = new Rational(3, 6); //Rational object with 2 arguments.
            Rational rationalObjectFour = new Rational(numerator: 2,
                denominator: 4); //Rational object with 2 arguments using named instantiation


            /*
             * Printing any two from the above rational objects, post which we 
             * will call the IncreaseBy(Rational) method and print the object again
            */
            Console.WriteLine("Checking Rational Addition and Subtraction!");

            Console.WriteLine($"\nFirst rational object has = {rationalObjectOne}");
            Console.WriteLine($"Second rational object has = {rationalObjectTwo}");

            //Calling the IncreaseBy(Rational) method
            rationalObjectOne.IncreaseBy(rationalObjectTwo);

            //Printing out the new rational object value
            Console.WriteLine("Increasing the First Rational Object by adding " +
                $"\nthe Second Rational Object to it we get: {rationalObjectOne}");


            //Printing a line that helps create a division between the two methods
            Console.WriteLine("-----------------------------------------------");


            /*
            * Printing any two from the above rational objects, post which we 
            * will call the DecreseBy(Rational) method and print the object again
           */
            Console.WriteLine($"\nThird rational object has = {rationalObjectThree}");
            Console.WriteLine($"Fourth rational object has = {rationalObjectFour}");

            //Calling the IncreaseBy(Rational) method
            rationalObjectThree.DecreaseBy(rationalObjectFour);

            //Printing out the new rational object value
            Console.WriteLine("Decreasing the Third Rational Object by subtracting " +
                $"\nthe Fourth Rational Object from it we get: {rationalObjectThree}");

        }//end main
    }//end class
}//end namespace
