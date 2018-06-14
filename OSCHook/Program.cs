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
