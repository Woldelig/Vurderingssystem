using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace adminPanel
{
    class Multithread
    {
        //Initaliserer en ThreadStart som kjører nyThread-metoden fra LoginForm
        ThreadStart nyBrukerThread = new ThreadStart(new LoginForm().nyThread);
        Thread thread;

        public Multithread()
        {
            //Initaliserer thread med nyBrukerThread
            if (thread == null)
            {
                thread = new Thread(nyBrukerThread);
            }
            //Hvis det allerede eksisterer en thread så må vi avslutte den
            else
            {
                StopThread();
            }
        }

        //Starter threaden
        public void StartThread()
        {
            if (!thread.IsAlive)
            {
                thread.Start();
            }
        }
        
        //Stopper threaden
        public void StopThread()
        {
            thread.Abort();
        }
    }
}