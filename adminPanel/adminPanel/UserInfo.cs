using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adminPanel
{
    class UserInfo
    {
       static private String username;

        static public String Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }
    }
}