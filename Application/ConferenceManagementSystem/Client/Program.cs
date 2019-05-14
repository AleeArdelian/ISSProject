using Common.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISSgui
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            TcpChannel chan = new TcpChannel();
            ChannelServices.RegisterChannel(chan, false);
            IService service = (IService)Activator.GetObject(
                     typeof(IService),
                     "tcp://localhost:8888/cmsservice"
            );
            //obj.FindAllListeners();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginWindow(service));
        }
    }
}
