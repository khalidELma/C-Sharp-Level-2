using System;
using System.Reflection;

class Program
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class RangeAttribute : Attribute
    {
        public int Min { get; }
        public int Max { get; }

        public string ErrorMessage { get; set; }
        public string Message { get; set; }

        public RangeAttribute(int min, int max)
        {
            Min = min;
            Max = max;
        }
    }

    public class Person
    {
        [Range(18, 99, ErrorMessage = "Age must be between 18 and 99")]
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class Product
    {
        [Range(0, 500, Message = "There might be a discount next week.",
               ErrorMessage = "Price must be between 0 and 500")]
        public int Price { get; set; }

        [Range(0, 500, Message = "The product will be available in a week.",
               ErrorMessage = "Stock must be between 0 and 500")]
        public int Stock { get; set; }
    }

    public static void Main(string[] args)
    {
        Person person = new Person { Age = 15, Name = "Khalid" };
        Validate(person);

        Product p1 = new Product { Price = 800, Stock = 1700 };
        Product p2 = new Product { Price = 30, Stock = 50 };

        Validate(p1);
        Validate(p2);
    }

    public static bool Validate(object obj)
    {
        Type type = obj.GetType();
        bool isValid = true;

        foreach (var property in type.GetProperties())
        {
            var rangeAttribute = property.GetCustomAttribute<RangeAttribute>();
            if (rangeAttribute != null)
            {
                int value = (int)property.GetValue(obj);
                if (value < rangeAttribute.Min || value > rangeAttribute.Max)
                {
                    Console.WriteLine($"Validation failed for {property.Name}: {rangeAttribute.ErrorMessage}");
                    if (!string.IsNullOrEmpty(rangeAttribute.Message))
                        Console.WriteLine(rangeAttribute.Message);

                    isValid = false;
                }
            }
        }

        return isValid;
    }
}
