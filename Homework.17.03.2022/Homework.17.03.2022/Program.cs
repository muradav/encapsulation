using Homework._17._03._2022.Models;
using System;

namespace Homework._17._03._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             User class
            - Username
            - Age
            - Password
            Username, password property-ləri olmadan user obyekti yaratmaq olmaz.
            Age propery-i mənfi ola bilməz.
            Password property-i bu şərtləri ödəməlidir:
            1. Boş ola bilməz
            2. Uzunluğu 8-dən kiçik ola bilməz
            3. İçində ən az bir böyük hərf olmalıdır
            4. İçində ən az bir rəqəm olmalıdır
            Üçüncü və dördüncü şərti ayrı bir private methodda yazıb gəlib propertyinin setində istifadə etmək lazımdır.
             */

           
            Console.Write("Please enter the username: ");
            string username = Console.ReadLine();

            Console.Write("Please enter the password: ");
            string password = Console.ReadLine();

            Console.Write("Please enter the age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("==========================");

            
            User user1 = new User(username,password);
            user1.Age = age;
            user1.GetInfo();

            
            
            
        }
    }
}
