using System;

namespace UserRegistrationUsingReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tUser Registration using Reflection");
            ValidateUserDetails validate = new ValidateUserDetails();
            validate.ValidateUser();
        }
    }
}
