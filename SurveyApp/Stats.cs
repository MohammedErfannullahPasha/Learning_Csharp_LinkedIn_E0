using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp
{
    
    //This class will simulate that marketing team is binding/registering/subscribing to the event.
    //marketing team is the subscriber.
    class Stats
    {
        public void Start()
        {
            //subscribing the event by += operator
            //to unsubscribe from event use -= operator
            
            //if the subscriber is not subscribed/registered the event
            //Program.Posted += HasPosted;
        }

        //by default below is private method
        //below method is called as event handler
        void HasPosted()
        {
            Console.WriteLine("Survey posted, Run stats");
        }
    }
}
