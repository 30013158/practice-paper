/*Rajveer kaur
 test practice*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_paper
{
    class Program
    {
        static void Main(string[] args)
        {//ques 1
          Console.WriteLine("*******Ques1******");
          Console.WriteLine("Please enter any letter to know whether it is a vowel or consonant");
          string input =(Console.ReadLine().ToUpper());
          if (input=="a" || input =="e" || input=="i" || input=="o" || input=="u")
          {
              Console.WriteLine("This is a vowel");
          }
          else
          { Console.WriteLine("This is a consonant"); }
          Console.WriteLine("you have completed the task \n press enter to move to the next");
          Console.ReadLine();

          //ques2
          Console.WriteLine("*******Ques2******");
          Console.WriteLine("this app will calculate your BMI");
          Console.WriteLine("please enter your weight in kg's: ");
          double weight = double.Parse(Console.ReadLine());
          Console.WriteLine("now enter your height:");
          double height = double.Parse(Console.ReadLine());
          Console.WriteLine($"your BMI is : {weight / (height * height)}");
          Console.WriteLine("please press enter to continue");
          Console.ReadLine();

          //ques 3
          Console.WriteLine("*******Ques3******");
          Console.WriteLine("This app will calculate the sum of 20 numbers");
          int sum =0;
          for(int i =1; i<=20; i++)
          {
              Console.Write($"Please enter number {i} :");
              sum += int.Parse(Console.ReadLine());
          }
          Console.WriteLine($"the sum of all numbers is : {sum}");
          Console.WriteLine("please press enter to continue");
          Console.ReadLine();

            

            /*Q4*/
            int counter = 1;
            int total = 1;
            while(counter <=10 )
            {
                Console.WriteLine(total);
                total = total * counter;
                //total *= counter
                counter++;
            }
            Console.WriteLine("press enter");
            Console.ReadLine();
        }
    }
}
