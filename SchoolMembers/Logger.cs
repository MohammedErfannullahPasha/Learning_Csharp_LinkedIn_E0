using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMember
{
    //As the appliction is grown a lot, we would want to construct a logger feature/class that can track the health of app during execution.
    //We will deploy the log method in each of the class to 1-track progress, 2-Priority & 3-the class in which it is running 
    public class Logger
    {
        
        //lets provide an optional argument to priority and this will be default value when we do not pass any argument when method is invoked
        //Madatory : optional parameter should appear at the end.
        //creating optional argument for System and it should be constant and constant cannot be marked static as const is static
        const string DefaultSystem = "SchoolMember Main";
        public static void Log(string Message, string System = DefaultSystem, int Priority = 1 )
        {
            //String interpolation : new way of passing variables data into WriteLine method
            Console.WriteLine($"System: {System} \t Priority: {Priority} \t Log Message: {Message}");
        }
    }
}
