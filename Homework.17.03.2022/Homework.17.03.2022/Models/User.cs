using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework._17._03._2022.Models
{
    class User
    {
        private string _username;
        private int _age;
        private string _password;


        public  string Username
        { 
            get; 
            set; 
        }
        public int Age
        {
            get

            {
                return _age;
            }

            set
            {
                
                if (value < 0) 
                    
                {
                    
                    Console.WriteLine("Age can't be negative!");
                    
                    return;
                }
                _age = value;


            }


        }
        public string Password 
        {
            get
            {
                return _password;
            }
            set 
            {
                
                if (string.IsNullOrEmpty(value)== true || !(value.Length >= 8) || IsPasswordValid(value)== false)
                {
                    
                    Console.WriteLine("Password invalid \n" +
                    "Please use at least one upper case and one digit");
                    Console.WriteLine("==========================");

                    return;
                }
                _password = value;
            } 
        }

        
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public void GetInfo()
        {
            Console.WriteLine("==========================");
            Console.WriteLine($"Username: {Username} \n" +
                $"Password: {Password} \n" +
                $"Age: {Age}");
        }


        
        public bool IsPasswordValid(string password)
        {
            char[] arr = password.ToCharArray();
            
            bool result = false;
            bool result1 = false;
            bool result2 = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (result1 != char.IsUpper(arr[i])) 
                {
                    result1 = true;
                }


                if (result2 != char.IsDigit(arr[i]))
                {
                    result2 = true;
                }
                if (result1 == true && result2 == true) 
                {
                    result = true;

                }
                



            }

            return result;
            
            
          
                   
        }
    }
}
