using Gma.System.MouseKeyHook;
using SharpOSC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSCHook
{
    class LogMouse
    {
        public static UDPSender sender = null;
        public static String url;
        public static int port;

        public static void Do(Action quit)
        {
        Console.WriteLine("Sending OSC to "+url+" port "+port);
        sender = new UDPSender(url, port);

        Hook.GlobalEvents().MouseClick += LogMouse_MouseClick;

        }

        private static void LogMouse_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Console.WriteLine("Mouse: " + e.Button);
            int btn = 0;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                btn = 0;
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                btn = 1;
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Middle)
            {
                btn = 2;
            }
            else
            {
                btn = -1;
            }

            var message = new OscMessage("/mouse", btn);
            LogMouse.sender.Send(message);
            Console.WriteLine("[OSC] Mouse Click: "+btn);
        }
    }
}
