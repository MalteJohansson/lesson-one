using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region WarmUp

            //string petName = "";

            //Console.WriteLine("Do your have a cat or dog?");
            //string pet = Console.ReadLine().ToLower();

            //if (pet == "cat" || pet == "dog")
            //{
            //    Console.WriteLine("What is the name of your pet?");
            //    petName = Console.ReadLine();
            //    Console.WriteLine($"You are a proud {pet} owner, and its name is {petName}.");
            //}

            //else
            //{
            //    Console.WriteLine("Error in handeling information.");
            //}

            #endregion

            #region Switch statement

            //Console.WriteLine("What major swedish city do you live closest to? (Göteborg, Malmö, Stockholm)");
            //string city = Console.ReadLine();

            //switch (city.ToLower())
            //{
            //    case "göteborg":
            //        {
            //            Console.WriteLine("Your name must be Glen");
            //        }
            //        break;

            //    case "malmö":
            //        {
            //            Console.WriteLine("You sound French");
            //        }
            //        break;

            //    case "stockholm":
            //        {
            //            Console.WriteLine("You must be fancy");
            //        }
            //        break;

            //    default:
            //        {
            //            Console.WriteLine("Invalid response");
            //        }
            //        break;
            //}

            //Console.WriteLine("Write a number between 1 and 10");
            //int answer = Convert.ToInt32(Console.ReadLine());

            //switch (answer)
            //{
            //    case 0:
            //        {
            //            Console.WriteLine("Invalid response");
            //        }
            //        break;

            //    case 1:
            //    case 2:
            //    case 3:
            //    case 4:
            //        {
            //            Console.WriteLine("You guessed low");
            //        }
            //        break;

            //    case 5:
            //        {
            //            Console.WriteLine("You guessed in the middle");
            //        }
            //        break;

            //    case 6:
            //    case 7:
            //    case 8:
            //    case 9:
            //    case 10:
            //        {
            //            Console.WriteLine("You guessed high");
            //        }
            //        break;

            //    default:
            //        {
            //            Console.WriteLine("NaN");
            //        }
            //        break;
            //}

            //int correctAnswer = new Random().Next(1, 11);

            //Console.WriteLine("Guess a number between 1-10");
            //int userAnswer = Convert.ToInt32(Console.ReadLine());

            //if (userAnswer == correctAnswer)
            //{
            //    Console.WriteLine("You guess the right number!");
            //    switch (correctAnswer)
            //    {
            //        case 1:
            //        case 2:
            //        case 3:
            //        case 4:
            //            {
            //                Console.WriteLine("The number is low");
            //            }
            //            break;
            //        case 5:
            //        case 6:
            //        case 7:
            //        case 8:
            //        case 9:
            //        case 10:
            //            {
            //                Console.WriteLine("The number is high");
            //            }
            //            break;

            //    }
            //}
            //else if (userAnswer != correctAnswer)
            //{
            //    Console.WriteLine("You guessed the wrong number.");
            //    switch (correctAnswer)
            //    {
            //        case 1:
            //        case 2:
            //        case 3:
            //        case 4:
            //            {
            //                Console.WriteLine("The number is low");
            //            }
            //            break;
            //        case 5:
            //        case 6:
            //        case 7:
            //        case 8:
            //        case 9:
            //        case 10:
            //            {
            //                Console.WriteLine("The number is high");
            //            }
            //            break;
            //        default:
            //            {
            //                Console.WriteLine("You guessed number is out of range");
            //                break;
            //            }
            //    }
            //}
            #endregion
            #region Loops

            //Incrementing or loop
            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Decrementing for loop
            //for (int i = 20; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (int i = 20; i >= 1; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //While loop

            //int randomNumber = 0;

            //while (randomNumber != 3)
            //{
            //    randomNumber = new Random().Next(1, 4);
            //    Console.WriteLine($"Random number is {randomNumber}");
            //}

            //int randomNumber = 0;

            //Console.WriteLine("Guess a number between 1-100.");
            //int userNumber = Convert.ToInt32(Console.ReadLine());
            //randomNumber = new Random().Next(1, 101);

            //while (userNumber != randomNumber)
            //{
            //    if (userNumber > randomNumber)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine($"You guessed {userNumber}, thats greater than the random number.");
            //        Console.WriteLine("Guess again");
            //        userNumber = Convert.ToInt32(Console.ReadLine());
            //    }

            //    else if (userNumber < randomNumber)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        Console.WriteLine($"You guessed {userNumber}, thats less than the random number.");
            //        Console.WriteLine("Guess again");
            //        userNumber = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"You guessed {userNumber}, that is correct!");

            #endregion

            #region Lists and Arrays
            //____________________________________________________________________________________________
            ////create a new array with three spots

            //string[] cities = new string[3];

            ////first spot in array

            //cities[0] = "Göteborg";
            //cities[1] = "Stockholm";
            //cities[2] = "Malmö";

            //Console.WriteLine(cities[0]);
            //Console.WriteLine(cities[1]);
            //Console.WriteLine(cities[2]);

            //string[] swedishCities = { "Uppsala", "Borås", "Kinna" };
            //____________________________________________________________________________________________
            ////in array


            //int[] years = { 2014, 1649, 1776 };

            ////a list is similar to an array, but you can add and remove items from it
            ////it does not have to be a fixed amount

            //List<string> moreSwedishCities = new List<string>();
            //moreSwedishCities.Add("Lidköping");
            //moreSwedishCities.Add("Kungsbacka");
            //moreSwedishCities.Add("Växjö");

            //moreSwedishCities.Remove("Växjö");

            //List<string> usaCities = new List<string>
            //{
            //    "Los Angeles",
            //    "San Diego",
            //    "Manhattan",
            //    "Philidelphia",
            //    "Houston"
            //};

            ////for (int i = 0; i < usaCities.Count; i++)
            ////{
            ////    Console.WriteLine($"The city at index {i} is {usaCities[i]}");
            ////}

            //foreach (string city in usaCities)
            //{
            //    Console.WriteLine($"The city is: {city}");
            //}

            //List<string> animalList = new List<string>();

            //Console.WriteLine("Write the name of an animal.");
            //string animal1 = Console.ReadLine();
            //animalList.Add(animal1);

            //Console.WriteLine("Write the name of an animal.");
            //string animal2 = Console.ReadLine();
            //animalList.Add(animal2);

            //Console.WriteLine("Write the name of an animal.");
            //string animal3 = Console.ReadLine();
            //animalList.Add(animal3);

            //foreach (string animal in animalList)
            //{
            //    Console.WriteLine($"You wrote: {animal}");
            //}

            #region Assignment 1


            //int[] arrayOfNumbers = new int[10];

            //for (int i = 0; i < arrayOfNumbers.Length; i++)
            //{
            //    arrayOfNumbers[i] = i;
            //}

            //List<int> listOfNumbers = new List<int>();

            //foreach (int number in arrayOfNumbers)
            //{
            //    listOfNumbers.Add(number);
            //}

            //foreach (int value in listOfNumbers)
            //{
            //    Console.WriteLine(value);
            //}

            #endregion

            #region In class assignments/homework


            //Console.WriteLine("Welcome to FizzBuzz!");

            //for (int number = 1; number <= 100; number++)
            //{

            //    if (number % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }

            //   else  if (number % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }

            //   else if (number % 3 == 0 && number % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //   else
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int x;
            //int y;

            //Console.WriteLine("Please write a number to be multiplied by.");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("\n");

            //for (y = 1; y <= 10; y++)
            //{
            //    Console.WriteLine($"{y} X {x} = {y * x} \n");
            //}

            //int[] arrayOfNumbers = new int[25];
            //Console.WriteLine("What numbers do you want to put in the array?");

            //for (int i = 0; i == 25; i++)
            //{
            //    Console.ReadLine();
            //}

            #region Homework 1

            //int[] userinput = new int[25];
            //int totalsum = 0;

            //Console.WriteLine("This program will let your add 25 numbers and then count their total sum.");

            //for (int i = 0; i < userinput.Length; i++)
            //{
            //    Console.WriteLine("please write a number");
            //    userinput[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < userinput.Length; i++)
            //{
            //    totalsum += userinput[i];
            //}
            //Console.WriteLine($"the total sum of all your numbers are {totalsum}");

            //James Solution

            //int[] intArray = new int[25];

            //int i;
            //int numberOfElementsInArray;
            //int sum = 0;

            //Console.WriteLine("Inout the number of elements to be stored in the array (1-25).");
            //numberOfElementsInArray = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Input {numberOfElementsInArray} elements in the array");

            //for (i = 0; i < numberOfElementsInArray; i++)
            //{
            //    Console.Write($"Elements - {i} :");
            //    intArray[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (i = 0; i < numberOfElementsInArray; i++)
            //{
            //    sum += intArray[i];
            //}

            //Console.WriteLine($"The sum of all elements in the array is : {sum}");
            #endregion

            #region Homework 2

            //int count = 0;
            //string userInput = "";

            //Console.WriteLine("Write a sentence.");
            //userInput = Console.ReadLine().ToLower();

            //foreach (char item in userInput)
            //{
            //    if (item == 'a')
            //        count++;
            //    if (item == 'e')
            //        count++;
            //    if (item == 'i')
            //        count++;
            //    if (item == 'o')
            //        count++;
            //    if (item == 'u')
            //        count++;

            //}
            //Console.WriteLine("Total number of vowels is {0}", count);

            //James solution

            Console.WriteLine("Write a sentence");

            string stringToCheck = Console.ReadLine().ToLower();
            Console.WriteLine($"Checking string '{stringToCheck}' for vowels.");

            int count = 0;

            foreach (char vowel in stringToCheck)
            {
                if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
                {
                    count++;
                }
            }

            Console.WriteLine($"There are {count} vowels in your sentence.");




            #endregion



















            #endregion
            #endregion
        }
    }
}
