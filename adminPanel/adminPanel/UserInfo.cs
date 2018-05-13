using System;

namespace adminPanel
{
    // En aksessor og mutator for å kunne hente ut brukernavnet i andre klasser.
    class UserInfo
    {
       static private String username;

        static public String Username
        {
            // Get-metoden
            get
            {
                return username;
            }
            // Set-metoden
            set
            {
                username = value;
            }
        }
    }
}