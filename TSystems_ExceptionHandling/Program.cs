using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_ExceptionHandling
{
   internal class Program
  public   class Program
    {
       
        static void Main(string[] args)
        {
             @@ -39,7  +39,17 @@ 
        Console.WriteLine("---------------custom Exception-----------------");
            user u = new user();
            try
            {
                int age = u.AcceptAge(13);
                Console.WriteLine("your  age is "+age);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

    }

    }
}
