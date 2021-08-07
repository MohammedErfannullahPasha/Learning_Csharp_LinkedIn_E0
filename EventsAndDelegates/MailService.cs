using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{
    
    //this class will send an email and waits for the publisher to complete the event i.e., videoencoding.
    class MailService
    {
        //Creating an event handler method. ensure the method signature should be same as delegate.
        //This method will simulate the behaviour of sending an email 
        public void SubVideoEncodedMail(object source, EventArgs args)
        {
            Console.WriteLine("Mail Service : Sending an Email....");
        }

    }
}
