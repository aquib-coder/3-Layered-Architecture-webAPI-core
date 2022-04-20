using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Person
{
    public class PersonBLL : IPersonBLL
    {
        private IPersonDAL _IPersonDAL;
        public PersonBLL(IPersonDAL _IpersonDAL)
        {
            _IPersonDAL = _IpersonDAL;
        }
        public string display()
        {
            return _IPersonDAL.display();
        }
    }
}
