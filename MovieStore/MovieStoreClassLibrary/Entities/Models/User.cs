using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreClassLibrary.Entities.Enums;

namespace MovieStoreClassLibrary.Entities.Models
{
    public class User : Member
    {
        public int MemberNumber { get; set; }
        public Subscription TypeOfSubscription { get; set; }
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public List<int> ToSetAnId { get; set; }

        public User()
        {
        }

        public User(string firstName, string lastName, string age, string userName, string password, string phoneNumber, DateTime dateOfRegistration, Subscription typeOfSubscription, List<int> userIds) : base(firstName, lastName, age, userName, password, phoneNumber, dateOfRegistration)
        {
            ToSetAnId = userIds;
            MemberNumber = SetId();
            TypeOfSubscription = typeOfSubscription;
            Role = Role.User;
        }

        public void SeeMembershipInfo()
        {
            DateTime oneMonthFromNow = DateOfRegistration.AddMonths(1);

            DateTime oneYearFromNow = DateOfRegistration.AddYears(1);

            TimeSpan daysUntilExpirationOfMembership;

            Console.WriteLine($"\nThis is your membership info:");

            Console.WriteLine($"\nName: { FirstName} { LastName}\n\nUsername: {UserName}");

            Console.Write($"\nYour subscription is:");

            if (TypeOfSubscription == Subscription.Monthly)
            {
                Console.WriteLine(" Monthly;");
                daysUntilExpirationOfMembership = oneMonthFromNow.Subtract(DateTime.Now);
            }

            else
            {
                Console.WriteLine(" Annual;");
                daysUntilExpirationOfMembership = oneYearFromNow.Subtract(DateTime.Now);
            }

            if ((int)daysUntilExpirationOfMembership.TotalDays < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nPlease renew your subscription. Your membership has expired.");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nYou have {(int)daysUntilExpirationOfMembership.TotalDays} days until your membership expires.");
                Console.ResetColor();
            }
        }

        public int SetId()
        {
            Random random = new Random();

            MemberNumber = random.Next(1, 100000);
            foreach (int num in ToSetAnId)
            {

                while (MemberNumber == num)
                {
                    MemberNumber = random.Next(1, 100000);
                }

            }

            return MemberNumber;
        }
    }
    
}
