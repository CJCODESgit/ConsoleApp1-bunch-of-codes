using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{

		static void Main(string[] args)
		{

			Book book1 = new Book();
			book1.title = "Harry Potter";
			book1.author = "JK Rowling";
			book1.pages = 500;

			Book book2 = new Book();
			book2.title = "Lord Of the Rings";
			book2.author = "Tolkein";
			book2.pages = 700;

			Console.WriteLine(book1.pages);
			Console.WriteLine(book2.author );

			Console.ReadLine();
			}
        }
	 }


/*



// C# BASICS
string characterName = "Tom";
int characterAge;
characterAge = 25;

Console.WriteLine("There is a guy named " + characterName);
Console.WriteLine("He is "+ characterAge +" years old");
characterName = "Mike";
Console.WriteLine("He loved his name " + characterName);
Console.WriteLine("But doesn't like being " + characterAge);

//STRING CONCATENATION USING + OPERATOR
string firstName = "John ";
string lastName = "Doe";
string name = firstName + lastName;
Console.WriteLine(name);
// STRING COCATENATION USING string.Concat
string firstName = "CJ ";
string lastName = "CODES";
string name = string.Concat(firstName, lastName);
Console.WriteLine(name);

// String Interpolation
string firstName = "CJ";
string lastName = "CODES";
string name = $"My full name is: {firstName} {lastName}";
Console.WriteLine(name);

string myString = "Hello World";
Console.WriteLine(myString[0]);
Console.WriteLine(myString.IndexOf("o"));
Console.WriteLine(myString.Substring(5));


//Boolean Values
bool isCSharpFun = true;
bool isFishTasty = false;
Console.WriteLine(isCSharpFun);
Console.WriteLine(isFishTasty);


Console.WriteLine("Enter username:");
string username = Console.ReadLine();
Console.WriteLine("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is " + age " and your username is " +username );

int[] luckyNumbers = { 2, 4, 6, 8, 10, 11, 12 };

Console.WriteLine(luckyNumbers[0]);

Console.ReadLine();

//MAD LIBS GAME

string color, pluralNoun, celebrity;

Console.WriteLine("Enter a color: ");
color = Console.ReadLine();

Console.WriteLine("Enter a PluralNoun: ");
pluralNoun = Console.ReadLine();

Console.WriteLine("Enter a celebrity: ");
celebrity = Console.ReadLine();

Console.WriteLine("\n\nRoses are "+ color);
Console.WriteLine(pluralNoun +" are blue");
Console.WriteLine("I love "+ celebrity);

//Arrays

int[] luckyNumbers = {2, 4, 6, 8, 10, 12};
string[] friends = new string[5];
friends[0] = "Jim";
friends[1] = "CJCODES";
Console.WriteLine(friends[1]);
luckyNumbers[1] = 900;

Console.WriteLine(luckyNumbers[1]);


//LOOPS
//while loops
int i = 0;
while (i<5)
{
Console.WriteLine("Covenant");
i++;
}
//for loop
for (int i = 0; i<5; i++)
{
Console.WriteLine(i);
}

//foreach loop through strings
string[] friends = {"Ore", "Caleb", "Hadi", "Joshua", "coker", "fiyin"};
foreach (string i in friends)
{
Console.WriteLine(i);
}

//for loop through strings
for(int i= 0; i<friends.Length; i++)
{
Console.WriteLine(friends[i]);
}

//break 

for (int i = 0; i < 10; i++) 
{
	if (i == 4) 
{
	 break;
}
	Console.WriteLine(i);
}

//continue
for (int i = 0; i < 10; i++)
{
if (i == 4)
{
	continue;
}
Console.WriteLine(i);
}

// sort arrays
//sort a string
string[] friends = {"Ore", "Caleb", "Hadi", "Joshua", "coker", "fiyin"};
Array.Sort(friends);
foreach (string i in friends)
{
Console.WriteLine(i);
}

//sort an int
int[] myNumbers = { 5, 1, 7, 9 };
Array.Sort(myNumbers);
foreach (int i in myNumbers)
{
Console.WriteLine(i);
}

//System.Linq Namespace
int[] myNumbers = { 5, 1, 7, 9 };
Console.WriteLine(myNumbers.Min());
Console.WriteLine(myNumbers.Max());
Console.WriteLine(myNumbers.Sum());


//Booleans

bool isMale = true;

		if (isMale)
		{
			Console.WriteLine("You are male");
		}
		else
		{
			Console.WriteLine("You are not male"); 
		}


//C# METHODS
SayHi("Mike", 17 );
SayHi("John", 12);
SayHi("Tom", 13);
Console.ReadLine();
	}

static void SayHi(string name, int age)
{
Console.WriteLine("Hello " + name + " you are " + age);
}

// switch methods
static string GetDay(int dayNum)
        {
			string dayName;

            switch (dayNum)
            {
				case 0:
					dayName = "Sunday";
					break;
				case 1:
					dayName = "Monday";
					break;
				case 2:
					dayName = "Tuesday";
					break;
				case 3:
					dayName = "Wednesday";
					break;
				case 4:
					dayName = "Thursday";
					break;
				case 5:
					dayName = "Friday";
					break;
				case 6:
					dayName = "Saturday";
					break;
				default:
					dayName = "Invalid day Number";
					break;
			}
			return dayName;
        }

//GUESSING GAME
			string secretWord = "giraffe";
			string guess = "";
			int guessCount = 0;
			int guessLimit = 3;
			bool outOfGuesses = false;


			while (guess != secretWord && !outOfGuesses)
            {
				if (guessCount < guessLimit)
                {
					Console.WriteLine("Enter guess");
					guess = Console.ReadLine();
					guessCount++;
				}
                else
                {
					outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
				Console.WriteLine("You lose");
            }
            else
            {
				Console.WriteLine("You Win");
			}

		//Exponential methods
			Console.WriteLine(GetPow(3, 2)); 

			Console.ReadLine();
		}

		static int GetPow(int baseNum, int powNum)
        {
			int result = 1;

			for(int i = 0; i <powNum; i++)
            {
				result = result * baseNum;
            }
			return result;
			


		//2d ARRAYS

			int[,] numberGrid =
			{
				{1, 2 },
				{3, 4 },
				{ 5, 6}
			};

			Console.WriteLine(numberGrid[0, 1]);

			Console.ReadLine();

			//EXCEPTION HANDLING
            try
            {
				Console.WriteLine("Enter username:");
				string username = Console.ReadLine();
				Console.WriteLine("Enter your age: ");
				int age = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Your age is " + age + " and your username is " + username);
			}
            catch(Exception e)
            {
				Console.WriteLine(e.Message);
            }

*/
