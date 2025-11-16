using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RequiredAttribute
{
    internal class Program
    {
        [AttributeUsage(AttributeTargets.Property)]
        
         public class RequiredAttribute : Attribute 
        {
             public string _ErrorMessage { get; set; }
        }


        public class User
        {
            [Required(_ErrorMessage = "This Username is Empty or null")]
            public string Username { get; set; }

            [Required(_ErrorMessage = "This Email is Empty or null")]
            public string Email { get; set; }
        }

        static void Main(string[] args)
        {

            User user = new User{Username ="User1",Email="User1@gmail.com"};

            User user2 = new User { Username = "", Email = null };

            Validate(user);
            Validate(user2);


        }

        public static bool Validate(object obj)
        {
            Type type = obj.GetType();
            bool Isvalid = true;

            foreach(var Proparty in type.GetProperties())
            {
                
                if(Attribute.IsDefined(Proparty, typeof(RequiredAttribute)))
                {
                    var requiredAttribute = Proparty.GetCustomAttribute<RequiredAttribute>();
                    if (requiredAttribute != null) { 
                    
                        string Value = (string)Proparty.GetValue(obj);
                        if (string.IsNullOrEmpty(Value)) { 
                        
                            Console.WriteLine(requiredAttribute._ErrorMessage);

                        }
                    

                    
                    }

                    Isvalid = false;

                }

            }
            
            return Isvalid;
        }
        }
    }
