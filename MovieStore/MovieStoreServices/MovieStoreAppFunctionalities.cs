using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreClassLibrary.Entities.Enums;
using MovieStoreClassLibrary.Entities.Models;
using MovieStoreClassLibrary.Entities.Exceptions;
using System.Linq;

namespace MovieStoreServices
{
    public static class MovieStoreAppFunctionalities
    {

        #region Main menu text

        public static void MainMenuText()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\n=======================================================\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to Movieverse :)");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter 1, 2 or 3:\n" +
                "1. Login as Employee\n" +
                "2. Login as User\n" +
                "3. Register as a User if you don't have an account ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\n=======================================================\n");
            Console.ResetColor();

        }

        #endregion


        #region Check if member exists

        public static Member CheckIfMemberExists(List<Member> members)
        {
            Console.WriteLine("\nEnter a username");
            string username = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\nEnter a password");
            string password = Console.ReadLine();
            Console.Clear();

            foreach (Member member in members)
            {
                if (username == member.UserName && password == member.Password) return member;
            }
            return null;
        }

        #endregion


        #region Validate basic info
        public static bool ValidateFirstName(string firstName)
        {
            try
            {
                

                while (firstName.Length < 2)
                {
                    Console.Clear();
                    Console.WriteLine("\nFirst name must be at least 2 characters long.\n" +
                "\nPlease try again.");
                    PressAnyKey();

                    return false;
                }


            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                PressAnyKey();

            }

            return true;

        }


        public static bool ValidateLastName(string lastName)
        {
  
            try
            {
                while (lastName.Length < 2)
                {
                    Console.Clear();
                    Console.WriteLine("\nLast name must be at least 2 characters long.\n" +
                "\nPlease try again.");
                    PressAnyKey();

                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                PressAnyKey();

            }
            return true;

        }


        public static bool ValidateAge(string age)
        {
            
            try
            {

                int parsedAge = int.Parse(age);

                while (parsedAge < 16 || parsedAge > 120)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid age input! Please enter a number between 16 and 120.");
                    Console.ResetColor();
                    PressAnyKey();

                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n{ex.Message}");
                Console.ResetColor();
                PressAnyKey();
                return false;


            }
            return true;

        }

        #endregion


        #region Validate new username

        public static bool ValidateUsername (List<Member> members, string username)
        {
           
            foreach (Member member in members)
            {
                if (username == member.UserName)
                {
                    Console.Clear();
                    Console.WriteLine("\nUsername already exists. Please try again.");
                    PressAnyKey();

                    return false;
                }
            }

            if (username.Length < 4)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nUsername must be at least 4 characters long. Please try again");
                Console.ResetColor();
                PressAnyKey();

                return false;
            }
            else
                return true;
            
        }


        #endregion


        #region Validate new password

        public static bool ValidatePassword(List<Member> members, string password)
        {

            foreach (Member member in members)
            {
                if (password == member.Password)
                {
                    Console.Clear();
                    Console.WriteLine("\nPassword already exists. Please try again.");
                    PressAnyKey();
                    return false;
                }
            }

            if (password.Length < 8)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nPassword must be at least 8 characters long. Please try again");
                Console.ResetColor();
                PressAnyKey();

                return false;
            }
            else
                return true;

        }

        #endregion


        #region Date Validator
        public static DateTime DateValidator()
        {
            while (true)
            {
                try
                {
                    Console.Clear();

                    Console.WriteLine("\nEnter day of registration date:");

                    int dayOfDate = int.Parse(Console.ReadLine());

                   
                    Console.WriteLine("\nEnter month of registration date:");
                    int monthOfDate = int.Parse(Console.ReadLine());

                    
                    Console.WriteLine("\nEnter year of registration date:");
                    int yearOfDate = int.Parse(Console.ReadLine());

        
                    DateTime userDateTime = new DateTime(yearOfDate, monthOfDate, dayOfDate);
                    

                    return userDateTime;

                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou probably didn't enter a valid number or there is no such date as the one you entered (for example 31 february, 31 june...). Let's see:");
                    Console.WriteLine($"\n{ex.Message}");
                    Console.WriteLine("\nOoops! ");
                    Console.WriteLine("\nTry again.");
                    Console.ResetColor();
                    PressAnyKey();
                }
            }
        }

        #endregion


        #region Phone number validation method

        public static bool ValidatePhoneNumber(List<Member> members, string phoneNumInput)
        {
            try
            {
               
                return PhoneNumber(members, phoneNumInput);

            }
            catch (Exception ex)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nPlease try again.");
                PressAnyKey();

                Console.ResetColor();

            }
            return false;
        }
        #endregion


        #region Nesting Exceptions Practice
        public static bool PhoneNumber(List<Member> members, string phoneNumInput) // Moze e malku vishok kod, ama sakav da povezhbam nesting na Exceptions
        {
            try
            {

                long phoneNum = long.Parse(phoneNumInput);

                foreach (Member member in members)
                {
                    if (phoneNumInput == member.PhoneNumber)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPhone number already exists. Please try again.");
                        Console.ResetColor();
                        PressAnyKey();

                        return false;
                    }
                }

                if (phoneNumInput.Length != 9)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nThe number must be nine-digits long. Please try again.");
                    Console.ResetColor();
                    PressAnyKey();

                    return false;
                }

                return true;


            }
            catch (Exception ex)
            {
                if (ex.Message == "Value was either too large or too small for an Int64.")
                {
                    throw new NumberTooBigOrSmallException($"The number you entered was too big or too small ", ex);
                }
                else
                {
                    throw ex;
                }

            }

        }

        #endregion


        #region Validate Member (used for validating shared properties by all members)

        public static Tuple<string, string, string, string, string, string, DateTime> ValidateMember(List<Member> members)
        {

            string firstName;
            string lastName;
            string age;
            string userName;
            string password;
            string phoneNum;
            DateTime dateOfRegistration;

            do
            {
                Console.Clear();
                Console.WriteLine("\nEnter first name:\n");

                firstName = Console.ReadLine();
            }
            while (!ValidateFirstName(firstName));

            do
            {
                Console.Clear();

                Console.WriteLine("\nEnter last name:\n");

                lastName = Console.ReadLine();
            }
            while (!ValidateFirstName(lastName));

            do
            {
                Console.Clear();

                Console.WriteLine("\nEnter age:\n");

                age = Console.ReadLine();
            }
            while (!ValidateAge(age));

            do
            {
                Console.Clear();

                Console.WriteLine("\nEnter username:\n");

                userName = Console.ReadLine();
            }
            while (!ValidateUsername(members, userName));

            do
            {
                Console.Clear();

                Console.WriteLine("\nEnter password:\n");

                password = Console.ReadLine();
            }
            while (!ValidatePassword(members, password));

            do
            {
                Console.Clear();

                Console.WriteLine("\nEnter phone number:\n");

                phoneNum = Console.ReadLine();
            }
            while (!ValidatePhoneNumber(members, phoneNum));

            dateOfRegistration = DateValidator();


            return new Tuple<string, string, string, string, string, string, DateTime>(firstName, lastName, age, userName, password, phoneNum, dateOfRegistration);
        }


        #endregion


        #region Press any key 
        public static void PressAnyKey()
        {
            Console.WriteLine("\nPress any key to continue");
            char anyKey = Console.ReadKey(true).KeyChar;
        }

        #endregion


        #region User Register, Login and Options

        #region Register as User


        public static Tuple<List<Member>, List<int>> RegisterUser(List<Member> members, List<int> userIds)
        {

            var (firstName, lastName, age, userName, password, phoneNum, dateOfRegistration) = ValidateMember(members);

            Console.Clear();

            Console.WriteLine("\nChoose a type of subscription, enter:\n" +
                     "\n[1] for a monthly subscription\n" +
                     "\n[2] for an annual subscription");

            bool isSubscriptionsSuccess = int.TryParse(Console.ReadLine(), out int subscriptionType);

            while (!isSubscriptionsSuccess || subscriptionType != 1 && subscriptionType != 2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid input, please choose:\n" +
                    "\n[1] for a monthly subscription\n" +
                    "\n[2] for an annual subscription");
                Console.ResetColor();
                isSubscriptionsSuccess = int.TryParse(Console.ReadLine(), out subscriptionType);
            }

            Subscription typeOfSubscription = new Subscription();

            if (subscriptionType == 1) typeOfSubscription = Subscription.Monthly;
            else typeOfSubscription = Subscription.Annualy;
            Console.WriteLine(typeOfSubscription);


            User newUser = new User(firstName, lastName, age, userName, password, phoneNum, dateOfRegistration, typeOfSubscription, userIds);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nSuccessfully registered new user with username {newUser.UserName}.");
            Console.ResetColor();
            PressAnyKey();

            members.Add(newUser);
            userIds.Add(newUser.MemberNumber);
            return new Tuple<List<Member>, List<int>>(members, userIds);
        }
        #endregion


        #region User Login

        public static void LoginAsUser(List<Member> members, List<Movie> movies, List<int> userIds)
        {
            User userLoggingIn = (User)CheckIfMemberExists(members);

            while (userLoggingIn == null)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nNo such user!\n" +
                         "Did you want to log in as an employee?\n" +
                         "Or maybe just misspelled your username and/or password?\n" +
                         "In any case, please try again.");
                Console.WriteLine($"=======================================================");
                Console.ResetColor();
                PressAnyKey();


                CheckStatusOfApp(members, movies, userIds);
            }

            Console.Clear();

            Console.WriteLine($"\nWelcome, {userLoggingIn.UserName}");

            UserMenu(userLoggingIn, movies);

        }

        #endregion


        #region User menu 

        public static void UserMenu(User user, List<Movie> movies)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n==================================================");
            Console.WriteLine($"******************** MAIN MENU *******************");
            Console.WriteLine($"==================================================\n");

            Console.WriteLine("Enter number to choose an action:\n" +
                "[1] - View your membership info\n" +
                "[2] - Rent a movie\n" +
                "[3] - View movies you haven't returned\n" +
                "[0] - Exit application");
            Console.WriteLine($"\n==================================================\n");

            Console.ResetColor();

            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Console.Clear();
                    user.SeeMembershipInfo();
                    PressAnyKey();
                    Console.Clear();
                    UserMenu(user, movies);
                    break;
                case 2:
                    RentAMovie(user, movies);
                    Console.Clear();
                    UserMenu(user, movies);
                    break;
                case 3:
                    ViewRentedMovies(user);
                    Console.Clear();
                    UserMenu(user, movies);
                    break;
                case 0:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"\nThank you for using our app :) Until next time, {user.UserName}!");
                    Console.ResetColor();
                    PressAnyKey();
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOops.Something went wrong. Maybe you chose an incorrect number? Anyway, please try again.");
                    Console.ResetColor();
                    PressAnyKey();
                    break;
            }
        }

        #endregion


        #region User's rented movies list 

        public static void ViewRentedMovies(User loggedInUser)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine("These are the movies that you have rented:");
            Console.WriteLine("------------------------------------------\n");

            for (int i = 0; i < loggedInUser.Movies.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine($"{i + 1}. {loggedInUser.Movies[i].Title}");
            }

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n------------------------------------------");
           

            Console.ResetColor();
            PressAnyKey();
        }

        #endregion


        #region Rent a movie
        public static Tuple<List<Movie>, User> RentAMovie(User loggedInUser, List<Movie> allMovies)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                    Console.WriteLine("\n-----------------------------------------------------------------");
                    Console.WriteLine("Here's a list of all the movies we have available in Movieverse*:");
                    Console.WriteLine("-----------------------------------------------------------------\n");

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    for (int i = 0; i < allMovies.Count; i++)
                    {
                        if (allMovies[i].IsRented)
                            Console.WriteLine($"{i + 1}. {allMovies[i].Title} *");
                        else
                            Console.WriteLine($"{i + 1}. {allMovies[i].Title}");
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n* If a movie title has \"*\" sign displayed after it, it's not available because it's already been rented.");
                    Console.ResetColor();

                    Console.WriteLine("\nType in the number of the movie you would like to rent:");
                    int userMovieChoice = int.Parse(Console.ReadLine());

                    Movie chosenMovie;

                    foreach (Movie movie in allMovies)                  
                    {
                        if(userMovieChoice > allMovies.Count || userMovieChoice < 1)
                            throw new Exception($"There was no movie with the number you chose on the list."); 
                       
                    }

                    chosenMovie = allMovies.ElementAt(userMovieChoice - 1);

                    if (chosenMovie.IsRented)
                    {
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nThe movie you chose is currently unavailable because it's already been rented.");
                    }
                    else
                    {
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nYou have successfully rented the movie {chosenMovie.Title}. We hope you enjoy it :)");
                        allMovies.ElementAt(userMovieChoice - 1).IsRented = true;
                        loggedInUser.Movies.Add(chosenMovie);
                    }

                    Console.ResetColor();

                    PressAnyKey();

                    return new Tuple<List<Movie>, User>(allMovies, loggedInUser);

                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"\n{ex.Message}");
                    Console.WriteLine("\nPlease try again.");
                    Console.ResetColor();
                    PressAnyKey();

                }
            }
            
        }

        #endregion


        #endregion


        #region Employee Login, Authorization and Permissions


        #region Employee Login
        public static void LoginAsEmployee(List<Member> members, List<Movie> movies,  List<int> userIds)
        { 
            Employee empLoggingIn = (Employee)CheckIfMemberExists(members);

            while (empLoggingIn == null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nNo such employee!\n" +
                         "Did you want to log in as a user?\n" +
                         "Or maybe just misspelled your username and/or password?\n" +
                         "In any case, please try again.");
                Console.WriteLine($"=======================================================");
                Console.ResetColor();
                PressAnyKey();


                CheckStatusOfApp(members, movies, userIds);
            }

            Console.Clear();

            Console.WriteLine($"\nWelcome, {empLoggingIn.UserName}!");

            EmployeeMenu(empLoggingIn, members, movies, userIds);

        }

        #endregion


        #region Employee menu 

        public static void EmployeeMenu(Employee employee, List<Member> members, List<Movie> movies, List<int> userIds)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n==================================================");
            Console.WriteLine($"******************** MAIN MENU *******************");
            Console.WriteLine($"==================================================\n");

            Console.WriteLine("Enter number to choose an action:\n" +
                "[1] - View all members of Movieverse\n" +
                "[2] - View all the movies available for renting\n" +
                "[3] - Register a new employee\n" +
                "[4] - Register a new user\n" +
                "[5] - Delete a member\n" +
                "[0] - Exit application");
            Console.WriteLine($"\n==================================================\n");

            Console.ResetColor();

            int chosenOption = int.Parse(Console.ReadLine());


            switch (chosenOption)
            {
                case 1:
                    DisplayAllMembers(members);
                    Console.Clear();
                    EmployeeMenu(employee, members, movies, userIds);
                    break;               
                case 2:
                    DisplayAllMovies(movies);
                    Console.Clear();
                    EmployeeMenu(employee, members, movies, userIds);
                    break;
                case 3:
                    RegisterEmployee(members);
                    Console.Clear();
                    EmployeeMenu(employee, members, movies, userIds);
                    break;
                case 4:
                    RegisterUser(members, userIds);
                    Console.Clear();
                    EmployeeMenu(employee, members, movies, userIds);
                    break;
                case 5:
                    DeleteMember(members, employee);
                    Console.Clear();
                    EmployeeMenu(employee, members, movies, userIds);
                    break;
                case 0:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"\nThank you for using our app :) Until next time, {employee.UserName}!");
                    Console.ResetColor();
                    PressAnyKey();
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOops.Something went wrong. Maybe you chose an incorrect number? Anyway, please try again.");
                    Console.ResetColor();
                    PressAnyKey();
                    break;
            }


        }

        #endregion


        #region Display all members method

        public static void DisplayAllMembers(List<Member> members)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\nThese are all the members of Movieverse:\n");
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < members.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {members[i].FirstName} {members[i].LastName}");
            }

            Console.ResetColor();
            PressAnyKey();
        }

        #endregion


        #region Display all movies method
        public static void DisplayAllMovies(List<Movie> movies)
        {
            Console.Clear();

            if (movies.Count == 0)
                Console.WriteLine("\nThere are no movies currently. Go stock the moviestore with some blockbusters!");
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;

                Console.WriteLine($"\nThese are all the movies at Movieverse that are currently available for renting:\n");

                List<Movie> availableMovies = movies
                                        .Where(x => x.IsRented == false)
                                        .ToList();

                for (int i = 0; i < availableMovies.Count; i++)
                {
                    if (i % 2 == 0)
                        Console.ForegroundColor = ConsoleColor.Yellow;

                    else
                        Console.ForegroundColor = ConsoleColor.Cyan;

                    Console.WriteLine($"{i + 1}. Title: {availableMovies[i].Title};\n" +
                        $"Genre: {availableMovies[i].Genre};\n" +
                        $"Plot summary: {availableMovies[i].Description}\n");
                }
            }
            Console.ResetColor();
            PressAnyKey();
        }

        #endregion


        #region Register an Employee

        public static List<Member> RegisterEmployee(List<Member> members)
        {

            var (firstName, lastName, age, userName, password, phoneNum, dateOfRegistration) = ValidateMember(members);

            Console.Clear();

            Console.WriteLine("Enter working hours of new employee:");
            bool isWorkingHoursSuccess = int.TryParse(Console.ReadLine(), out int workingHours);

            while (!isWorkingHoursSuccess || workingHours < 80 || workingHours > 320)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid working hours input!\n" +
                    "\nMinimum (part-time) monthly working hours: 80\n" +
                    "\nMaximum (full-time) monthly working hours: 320\n" +
                    "\nPlease enter a number between 80 and 320.");
                Console.ResetColor();
                isWorkingHoursSuccess = int.TryParse(Console.ReadLine(), out workingHours);
            }


            Employee newEmployee = new Employee (firstName, lastName, age, userName, password, phoneNum, dateOfRegistration, workingHours);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nSuccessfully registered new employee with username {newEmployee.UserName}.");
            Console.ResetColor();
            members.Add(newEmployee);

            PressAnyKey();

            return members;
        }



        #endregion


        #region Delete an existing member

        public static List<Member> DeleteMember(List<Member> members, Employee loggedInEmp)
        {
            Console.Clear();
            
            Console.WriteLine("\nEnter username of member whose record you would like to delete:");

            Member memberToDelete = new Member();

            string memberUserName = Console.ReadLine();

            if (memberUserName == loggedInEmp.UserName)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYou can't delete yourself!");
                Console.ResetColor();
                PressAnyKey();
                return members;
            }

            foreach (Member member in members)
            {
                Console.WriteLine(member.UserName);
                if (memberUserName == member.UserName)
                {
                    memberToDelete = member;
                    break;
                }
                    
                else
                    memberToDelete = null;
            }

            if (memberToDelete == null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nThere is no record of a member with the username {memberUserName}.");
                Console.WriteLine("\nIf you want to try again, please choose the corresponding options from the menu.");
            }

            else
            {
                Console.Clear();
                members.Remove(memberToDelete);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nYou have successfully deleted {memberToDelete.UserName}");
            }

            Console.ResetColor();
            PressAnyKey();
            return members;
            
        }
        #endregion

        #endregion


        #region Check status of app

        public static void CheckStatusOfApp(List<Member> members, List<Movie> movies, List<int> userIds)
        {
            MainMenuText();

            int memberChoiceNum = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (memberChoiceNum)
            {
                case 1:
                    LoginAsEmployee(members, movies, userIds);
                    CheckStatusOfApp(members, movies, userIds);

                    break;
                case 2:
                    LoginAsUser(members, movies, userIds);
                    CheckStatusOfApp(members, movies, userIds);

                    break;
                case 3:
                    RegisterUser(members, userIds);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nWelcome to our Movieverse :)");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\nFollow the menu to log in with your new account.");
                    Console.ResetColor();
                    PressAnyKey();
                    CheckStatusOfApp(members, movies, userIds);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOops. Looks like something went wrong, or you didn't choose a valid number. Please try again.");
                    Console.ResetColor();
                    PressAnyKey();
                    CheckStatusOfApp(members, movies, userIds);

                    break;
            }

           
        }
        #endregion


        



    }
}
