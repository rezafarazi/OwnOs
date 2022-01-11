using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OwnOs.Plugins.CommentManager
{
    class CommentManager
    {

        //comment manager main function
        public static void Execute(string Comment)
        {
            switch (Comment)
            {
                //get clear screen
                case "clear":
                    Console.Clear();
                break;

                case "calculator":
                Calculator.Calculator.Start_Calculator();
                break;

                //get shutdown
                case "exit":
                    Power.Power.Shutdown();
                break;

            }
        }

    }
}
