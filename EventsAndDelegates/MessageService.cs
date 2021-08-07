using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class MessageService
    {
        //Event handler
        public void SubVideoEncodedMessage(object source, EventArgs args)
        {
            Console.WriteLine("Message Service : Sending a test message....");
        }
    }
}
