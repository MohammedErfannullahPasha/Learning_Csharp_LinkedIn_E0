using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMember
{
    
    //we cannot add Pay() method in Memberofschool method becasue that will make students to inherit the same.
    //we can use interface which imposes to define inherited method i.e., pay()
    //IPayee interface unifies all the payee classes
    interface IPayee
    {
        public void pay();
    }

    public class PayRoll
    {
        
        //imagine the payees increased in number and types of payee are also different ?
        //we can create a list of payees and can add any class (type of payee) that uses Ipayee interface. 
        List<IPayee> payees = new List<IPayee>();

        //create a constructor and add the instances 
        public PayRoll()
        {
            //adding instances of payees to list
            payees.Add(new Teacher());
            payees.Add(new Principal());

            //not passing input for priority as 1 is default set.
            Logger.Log("Payment has started","PayRoll Method");

        }

        public void PayAll()
        {
            foreach (var payee in payees)
            {
                payee.pay();
            }

            //not passing input for priority as 1 is default set.
            Logger.Log("Payment Completed","PayAll Method");

        }
    }
}
