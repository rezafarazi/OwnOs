using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OwnOs.Plugins.ThreadSleep
{
    class ThreadSleep
    {
        //i use for because not work thread.spleep in boot :)
        public static void Sleep(int mls)
        {
            for (int i = 0; i < mls*50000; i++)
            {
                
            }
        }

    }
}
