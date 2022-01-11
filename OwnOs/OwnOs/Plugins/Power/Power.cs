using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OwnOs.Plugins.Power
{
    class Power
    {

        //Get shotdown
        public static void Shutdown()
        {
            Cosmos.Sys.Deboot.ShutDown();
        }


        //Get shotdown
        public static void Reboot()
        {
            Cosmos.Sys.Deboot.Reboot();
        }

    }
}
