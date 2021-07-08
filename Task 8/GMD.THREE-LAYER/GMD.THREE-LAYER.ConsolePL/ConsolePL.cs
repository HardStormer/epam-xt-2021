using System;
using System.Collections.Generic;
using GMD.THREE_LAYER.Dependecies;
using GMD.THREE_LAYER.Entities;
using GMD.THREE_LAYER.StandartBLL;
using GMD.THREE_LAYER.BLL.Interfaces;

namespace GMD.THREE_LAYER.ConsolePL
{
    public static class ConsolePL
    {
        static void Main(string[] args)
        {
            var userBll = DependencyResolver.Instance.usersLogic;
            var awardBll = DependencyResolver.Instance.awardsLogic;

            Console.WriteLine("Welcome");
            Console.WriteLine("1 - Read all users");
            Console.WriteLine("2 - Read all awards");
            Console.WriteLine("3 - Add user");
            Console.WriteLine("4 - Add award");


            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    foreach (var user in userBll.GetAll())
                    {
                        WriteUser(user);
                    }
                    Main(args);
                    break;

                case "2":
                    foreach (var award in awardBll.GetAll())
                    {
                        WriteAward(award);
                    }
                    Main(args);
                    break;

                case "3":
                    Console.WriteLine("Имя");
                    var crName = Console.ReadLine();
                    Console.WriteLine("Дата рождения dd/MM/yyyy");
                    string crDate = Console.ReadLine();
                    DateTime dt;
                    while (!DateTime.TryParseExact(crDate, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
                    {
                        Console.WriteLine("Invalid date, please retry");
                        crDate = Console.ReadLine();
                    }
                    User newUser = new User();
                    newUser.Name = crName;
                    newUser.DateOfBirth = Dob(crDate);
                    newUser.ID = Guid.NewGuid();
                    userBll.Create(newUser);
                    Main(args);
                    break;

                case "4":
                    Console.WriteLine("Название");
                    var crTitle = Console.ReadLine();
                    
                    Award newAward = new Award();
                    newAward.Title = crTitle;
                    newAward.ID = Guid.NewGuid();
                    awardBll.Create(newAward);
                    Main(args);
                    break;

                default:
                    Main(args);
                    break;
            }
        }
        private static DateTime Dob(this string strLine)
        {
            DateTime result;
            if (DateTime.TryParseExact(strLine, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out result))
            {
                return result;
            }
            else
            {
                return DateTime.Now;
            }
        }
        private static void WriteUser(User user)
        {
            Console.WriteLine($"User id: {user.ID}");
            Console.WriteLine($"Name: {user.Name}");
            Console.WriteLine($"Date of birth: {user.DateOfBirth}");
            Console.WriteLine($"Age: {user.Age}");

            Console.WriteLine("Awards:");
            var i = 1;
            if (user.Awards != null)
            {
                foreach (var award in user.Awards)
                {
                    Console.WriteLine($"{i}. {award}");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
            

            Console.WriteLine("-------------------------");
        }

        private static void WriteAward(Award award)
        {
            Console.WriteLine($"Award id: {award.ID}");
            Console.WriteLine($"Title: {award.Title}");

            Console.WriteLine($"For users:");
            var i = 1;
            if (award.Users != null)
            {
                foreach (var user in award.Users)
                {
                    Console.WriteLine($"{i}. {award}");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("No users");
            }

            Console.WriteLine("-------------------------");
        }
    }
}
