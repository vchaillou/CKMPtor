using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CKMPtor
{
    public class SimulateurThread
    {
        private Thread thread; 

        public SimulateurThread(ThreadStart fonction)
        {
            thread = new Thread(fonction);
        }

        public void Lancer()
        {
            if (thread != null)
            {
                thread.IsBackground = true;
                thread.Start();
            }
        }

        public void Arreter()
        {
            if (thread != null) thread.Interrupt();
        }

        public void Pause()
        {
            if (thread != null) thread.Suspend();
        }
    }
}
