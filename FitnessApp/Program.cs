using System;
using System.Collections.Generic;

namespace FitnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Emri Mbiemri";
            char gjinia = 'f';
            int mosha = 20;



            var allMembers = new List<Members>() // Use Members from FitnessApp.Entities
            {
                new FitnessApp.Members()
                {
                    FirstName="Member1",
                    Email="email@gmail.com"
                },
                new FitnessApp.Members()
                {
                    // Initialize member properties
                    FirstName="Member2",
                    Email="email@gmail.com"
                }
            };

            foreach (var member in allMembers)
            {
                // Output member details
                Console.WriteLine($"Full Name: {member.FirstName}, Gender: {member.Gender}, Age: {CalculateAge(member.DOB)}");
            }

            Console.ReadLine();
        }

        private static object CalculateAge(object dOB)
        {
            throw new NotImplementedException();
        }

        // CalculateAge method definition
        static int CalculateAge(DateTime dob)
        {
            int age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.Month < dob.Month || (DateTime.Now.Month == dob.Month && DateTime.Now.Day < dob.Day))
            {
                age--;
            }
            return age;
        }
    }
}
