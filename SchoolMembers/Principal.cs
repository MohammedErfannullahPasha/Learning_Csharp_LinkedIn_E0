using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMember
{
    
    //by using IPayee interface, we must implement pay() method for/in Principal class
    class Principal : MemberOfSchool, IPayee
    {
         public void pay()
        {

            Console.WriteLine("Paying principal monthly salary");
            // below line is the default implementation
            //throw new NotImplementedException();
        }
    }
}
