using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMember
{
    
    //we cannot add Pay() method in Memberofschool method becasue that will make students to inherit the same.
    //we can use interface which imposes to define inherited method i.e., pay()
    interface IPayee
    {
        public void pay();
    }

    class PayRoll
    {
        Teacher teacher1 = new Teacher();
        Teacher teacher2 = new Teacher();
        Principal principal = new Principal();

        public void PayAll()
        {
            teacher1.pay();
            teacher2.pay();
            principal.pay();
        }
    }
}
