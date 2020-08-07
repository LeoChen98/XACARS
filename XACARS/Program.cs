using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace XACARS
{
    class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            Application app = new Application();
            app.Run(new MainWindow());
        }
    }
}
