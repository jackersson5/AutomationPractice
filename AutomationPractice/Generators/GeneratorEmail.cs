using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice
{
    class GeneratorEmail
    {
        public static string GenerateEmailAddress()
        {
            return "name" + GetRandomNumber() + "@automationpracticetestdomene.com";
        }

        // Generate random number for email address
        public static int GetRandomNumber()
        {
            return new Random().Next(100000, 100000000);
        }
          
    }
}
