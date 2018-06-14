using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSCHook
{
    class LogMouse
    {
            public static void Do(Action quit)
            {
                Console.WriteLine("Press Q to quit.");
            Hook.GlobalEvents().MouseClick += LogMouse_MouseClick;
                //Hook.GlobalEvents().KeyPress += (sender, e) =>
                //{
                //    Console.Write(e.KeyChar);
                //    if (e.KeyChar == 'q') quit();
                //};
            }

        private static void LogMouse_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Console.WriteLine("Mouse: " + e.Button);
            
        }
    }
}
