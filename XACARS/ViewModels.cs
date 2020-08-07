using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XACARS.ViewModel;

namespace XACARS
{
    internal class ViewModels
    {
        private static WindowControlCommands _WindowControl = new WindowControlCommands();


        public static WindowControlCommands WindowControl
        {
            get
            {
                return _WindowControl;
            }
        }
    }
}
