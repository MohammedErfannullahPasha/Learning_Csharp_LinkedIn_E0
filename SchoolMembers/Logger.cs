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
        public static void Log(string Message, int Priority, string System)
        {
            Console.WriteLine("System: {0} \t Priority: {1} \t Log Message: {2}", System, Priority, Message);
        }
    }
}
