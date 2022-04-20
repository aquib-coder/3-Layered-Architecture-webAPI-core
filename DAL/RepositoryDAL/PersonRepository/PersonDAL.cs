using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Person
{
   public class PersonDAL : IPersonDAL
    {
        public string display()
        {
            Console.WriteLine("In PersonDAL");
            return "hello";
          
        }
    }
}
