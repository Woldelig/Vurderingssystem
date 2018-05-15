using System.Threading;

namespace adminPanel
{
    class Multithread
    {
        // Initaliserer en ThreadStart som kjører nyThread-metoden fra LoginForm.
        ThreadStart nyBrukerThread = new ThreadStart(new LoginForm().NyThread);
        Thread thread;

        public Multithread()
        {
            // Initaliserer thread med nyBrukerThread.
            if (thread == null)
            {
                thread = new Thread(nyBrukerThread);
            }
            // Hvis det allerede eksisterer en thread så må vi avslutte den.
            else
            {
                StopThread();
            }
        }

        // Starter threaden
        public void StartThread()
        {
            if (!thread.IsAlive)
            {
                thread.Start();
            }
        }
        
        // Stopper threaden
        public void StopThread()
        {
            thread.Abort();
        }
    }
}