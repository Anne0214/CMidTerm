using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMain.Models
{
    public class LoginManagement
    {

        List<Staff> _list = new List<Staff>();
        

        public LoginManagement()
        {
            loadData();
        }

        private void loadData()
        {
            Staff x = new Staff();
            x.id = "001";
            x.name = "Martin";
            x.phone = "0988010473";
            x.email = "martin2023@gmail.com";
            x.address = "Taipei";
            x.password = "55688";
            _list.Add(x);
        }

        public Staff queryByEmail(string email)
        {
            foreach (Staff c in _list)
            {
                if (c.email == email)
                    return c;
            }
            return null;
        }
        public List<Staff> all
        {
            get { return _list; }
        }
    }
}
