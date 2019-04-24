using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using Server.Service;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel(8888);
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(CMSService), "cmsservice",
                WellKnownObjectMode.SingleCall
            );
            Console.WriteLine("[SERVER] Started...");
            String choice;
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n1. Add a conference");
                Console.WriteLine("\n2. See the conferences");
                Console.WriteLine("0. Exit");
                Console.Write("\nserver#: ");
                choice = Console.ReadLine();
                if (choice == "0")
                    running = false;
            }
            Console.WriteLine("[SERVER] Shuting down...");
        }
    }
}
