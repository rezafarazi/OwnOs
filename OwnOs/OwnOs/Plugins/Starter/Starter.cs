using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OwnOs.Plugins.Starter
{
    class Starter
    {
        //Get Starte Main Kernel
        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("Hello");

            ThreadSleep.ThreadSleep.Sleep(5000);


            Console.Clear();

            while (true)
            {
                Console.Write("Can i help you ? ");

                //Get pass user comment to comment manager
                CommentManager.CommentManager.Execute(Console.ReadLine().ToLower());
            }

        }

    }
}
