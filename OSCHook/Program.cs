using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSCHook
{
    class Program
    {
        static void Main(string[] args)
        {
                var quit = new AutoResetEvent(false);
            String url = "127.0.0.1";
            int port = 9000;
            if (args.Length > 0)
            {
                url=args[0];
            }
            if (args.Length > 1)
            {
                port = int.Parse(args[1]);
            }
            LogMouse.url = url;
            LogMouse.port = port;

            Action<Action> action = LogMouse.Do;
            action(Application.Exit);
                Application.Run(new ApplicationContext());
        }

        private static void Exit(Action quit)
        {
            Application.Exit();
        }
    }
}
