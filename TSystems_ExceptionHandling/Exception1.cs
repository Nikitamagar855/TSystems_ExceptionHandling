using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_ExceptionHandling
{
     public class Exception1:Exception
    {

        public Exception1(String msg) : base(msg)
        {

        }
    }

    public class user
    {
        public int AcceptAge(int age)
        {
            if (age < 18)
            {
                throw new Exception1("this user is not valid for vote");
            }

            return age;
        }
    }
}
