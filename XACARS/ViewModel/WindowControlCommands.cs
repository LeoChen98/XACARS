using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace XACARS.ViewModel
{
    /// <summary>
    /// 提供窗体控制命令
    /// </summary>
    internal class WindowControlCommands
    {
        /// <summary>
        /// 关闭窗口
        /// </summary>
        public RelayCommand<Window> Close
        {
            get
            {
                return new RelayCommand<Window>((sender) =>
                {
                    sender.Close();
                }, (sender) =>
                {
                    return sender != null;
                });
            }
        }

        /// <summary>
        /// 最小化窗口
        /// </summary>
        public RelayCommand<Window> MinSize
        {
            get
            {
                return new RelayCommand<Window>((sender) =>
                {
                    sender.WindowState = WindowState.Minimized;
                }, (sender) =>
                {
                    return sender != null;
                });
            }
        }

        /// <summary>
        /// 固定窗口最前
        /// </summary>
        public RelayCommand<Window> Pin
        {
            get
            {
                return new RelayCommand<Window>((sender) =>
                {
                    sender.Topmost = !sender.Topmost;
                }, (sender) => 
                { 
                    return sender != null; 
                });
            }
        }

    }
}
