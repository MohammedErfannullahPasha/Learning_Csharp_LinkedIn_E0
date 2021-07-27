using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMember
{
    class Teacher : MemberOfSchool, IPayee
    {
        public string Subject;

        public void pay()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Paying teacher monthly salary");
        }
    }
}
