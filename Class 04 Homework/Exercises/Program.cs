using System;
using System.Text.RegularExpressions;

namespace Exercises
{
    class Program
    {
        #region Task 01
        static void FunWithStrings(string userString)
        {

            //## Task 1
            //* Create a new method called FunWithStrings that will have one input parameter(string) and it will have no return
            //* In that method you should display in console the following tasks for the string:

            //* print the reverse string
            //* print total number of vowels
            //* check if string is palindrome
            //* print the largest word
            //* print the smallest word
            //* print the count of words
            //* print the most used character(not space obviously)
            //* Ask the user to enter a string and call the method with that string.

            while (userString.Trim().Length == 0)
            {
                Console.WriteLine("Your input must contain at least 1 character! Please try again!");
                userString = Console.ReadLine();
            }

            #region Print reversed string
            // Prints reversed string

            char[] stringToArray = userString.ToCharArray();
            Array.Reverse(stringToArray);
            string reversedString = string.Join("", stringToArray);
            Console.WriteLine($"The sentence you entered, when reversed, is: \"{reversedString}\".");
            #endregion


            #region Print total number of vowels
            // Prints total number od vowels

            int numOfVowels = 0;
            string userStringToLowercase = userString.ToLower();
            char[] arrayToCheckForVowels = userStringToLowercase.ToCharArray();

            foreach (char letter in arrayToCheckForVowels)
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                    numOfVowels++;
            }
            Console.WriteLine($"The total number of vowels in your sentence is: {numOfVowels}.");
            #endregion


            #region Check if string is a palindrome
            // Checks if string is a palindrome

            string checkIfPalindrome = userString.Replace(" ", "").ToLower();
            string checkIfPalindromeReversed = reversedString.Replace(" ", "").ToLower();

            if (checkIfPalindrome == checkIfPalindromeReversed)
                Console.WriteLine($"The sentence you entered (\"{userString}\") is a palindrome.");
            else
                Console.WriteLine($"The sentence you entered (\"{userString}\") is not a palindrome.");
            #endregion


            #region Print the largest word
            // Prints the largest word

            string onlyLettersAndNumbersString = Regex.Replace(userString, "[^a-zA-Z ]", String.Empty); // This regex leaves only letters and epmty spaces in the string entered by user, and I leave the spaces in the string, so that I can split the string by words, and compare the words length afterwards.
            string[] ArrayOfAllWords = onlyLettersAndNumbersString.Split(" ");
            int wordLength = 0;
            string largestWord = "";

            foreach (string word in ArrayOfAllWords)
            {
                word.Trim();
                
                if (word.Length > wordLength)
                {
                    wordLength = word.Length;
                    largestWord = word;
                }
            }

            if(largestWord.Length == 0) // With this validation I make sure that I don't print an illogical statement(largest word "", that is int.MaxValue long) in case if the user entered only a character that I have specifically removed with the regex for the purpose of this task (as well as the next one). 
                Console.WriteLine("Your input didn't contain any words!");
            else
            Console.WriteLine($"The largest word in the sentence you entered is \"{largestWord}\" and it is {wordLength} characters long.");
            #endregion


            #region Print the smallest word
            // Prints the smallest word

            int wordLength2 = int.MaxValue;
            string smallestWord = "";

            foreach (string word in ArrayOfAllWords)
            {
                word.Trim();
                if (word.Length == 0) // With some of the strings with which I tested this solution, the array with all the words that I am getting with .Split(" ") sometimes contains empty strings as elements (I think this happens when I enter some string like this "sdkfj 959 -05 ksjdfhv ksd", so when I remove all the unnecessary characters with the regex, it returns two empty spaces in a row, and  I guess that the split method treats one of them as a string, since I use only one empty space as a separator. I don't use this validation with the previous task (print largest word), since i have a while loop at the beginning that makes sure that the user's input will always be at least one character long, so in that case, that will automatically be the largest word, even if there are empty spaces in the string.
                    continue;
                else if(word.Length < wordLength2)
                {
                    wordLength2 = word.Length;
                    smallestWord = word;
                }
            }

            if (largestWord.Length == 0)
                Console.WriteLine("Your input didn't contain any words!");
            else
            Console.WriteLine($"The smallest word in the sentence you entered is \"{smallestWord}\" and it is {wordLength2} characters long.");

            // Both the Prints largest word and Prints smallest word tasks correctly evaluate the largest and smallest words in the user input string, but in case there are two or more words with the same length, this solution will print the first largest or smallest word it finds (It checks all with the foreach loop, obviously, it just doesn't change the value of largestWord and smallestWord if it finds one or more words with the same length along the array).
            #endregion


            #region Print the count of words
            // Prints the count of words

            int wordCounter = 0;
            foreach  (string word in ArrayOfAllWords)
            {
                if (word.Length == 0)
                    continue;
                else
                    wordCounter++;
                        
            }
            Console.WriteLine($"The sentence you entered has {wordCounter} words.");
            #endregion


            #region Print the most used character
            //  Prints the most used character

            string noSpacesString = onlyLettersAndNumbersString.Replace(" ", "");
            char[] lettersOnlyArray = noSpacesString.ToCharArray();
            char mostOccurencies = '0';
            int counter = 0;
            int counterAtEndOfLoop = 0;
            
            foreach (char character in lettersOnlyArray)
            {
                for (int i = 0; i < lettersOnlyArray.Length; i++)
                {
                    if (character == lettersOnlyArray[i])
                    {
                        counter++;
                        mostOccurencies = character;
                    }
                }
                if(counter > counterAtEndOfLoop)
                {
                    counterAtEndOfLoop = counter;
                }
                counter = 0;
            }
            Console.WriteLine($"The most used character in your input is the character \"{mostOccurencies}\", and it appears {counterAtEndOfLoop} times in the sentence.");
           // This solution is rather imperfect too, in the sense that if some of the characters appear the same number of times in the string, and it so happens that they are the characters with the most occurencies as well, this solution will tell the user that the char with the most occurencies is the one that occurs last in the string, even though another character may have appeared equal number of times before the one that is printed.
            #endregion
        }
        #endregion


        #region Task 02
        
        static void RemoveExtraSpace(string someString)
        {
            // Task 02
            //Create a new method that will remove extra space characters
            //* Call the method with the following text: The    best  Lorem  Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       above, then get yer pirate ipsum... own the high seas,    argh!

            someString = someString.Trim();
            string outputString = "";
            string []someStringArray = someString.Split(" ");

            foreach (string word in someStringArray)
            {
                if (word.Length == 0)
                    continue;
                outputString += $"{word} ";
            }

            Console.WriteLine(outputString);
        }

        #endregion


        static void Main(string[] args)
        {
            Console.WriteLine("Class 04 Homework");
            Console.WriteLine("--------------------------\n");

            Console.WriteLine("Task 01 - Fun With Strings");
            Console.WriteLine("Enter a sentence:");
            string userStringInput = Console.ReadLine();
            FunWithStrings(userStringInput);

            Console.WriteLine("\n-----------------------------------------\n");

            Console.WriteLine("Task 02 - Method that removes extra space");
            RemoveExtraSpace("The    best  Lorem  Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       above, then get yer pirate ipsum... own the high seas,    argh!");

            Console.ReadLine();
        }
    }
}
