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
        public static void Log(string Message, string System, int Priority = 1 )
        {
            Console.WriteLine("System: {0} \t Priority: {1} \t Log Message: {2}", System, Priority, Message);
        }
    }
}
