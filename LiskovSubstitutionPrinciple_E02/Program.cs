using System;
using LiskovSubstitutionPrinciple_E02.Abstract;
using LiskovSubstitutionPrinciple_E02.Implementation;
using LiskovSubstitutionPrinciple_E02.Interface;

namespace LiskovSubstitutionPrinciple_E02
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new GoldUser(1, "Sajad", 15000);
            User user2 = new SilverUser(2, "Mona", 15000);
            //User user3 = new AdminUser(3, "Admin", 15000);
            Console.WriteLine(user1.ToString());
            Console.WriteLine(user2.ToString());
            //Console.WriteLine(user3.ToString());


            IUser goldUser = new GoldUser(1,"Sajad",25000);
            IUser silverUser = new SilverUser(2,"Sajad",25000);
            IUser adminUser = new AdminUser(3,"Sajad",25000);
            Show(goldUser);
            Show(silverUser);
            Show(adminUser);
            Show(user1);
            Show(user2);
        }

        static void Show(IUser user)
        {
            Console.WriteLine(user);
        }
    }
}
