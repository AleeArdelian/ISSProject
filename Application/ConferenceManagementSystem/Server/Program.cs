using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using Server.Service;
using Common.Service;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel(8888);
            ChannelServices.RegisterChannel(channel, false);
    
            CMSService service = new CMSService();
            RemotingServices.Marshal(service, "cmsservice");

            Console.WriteLine("[SERVER] Started...");
            String choice;
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n1. Add a conference");
                Console.WriteLine("\n2. See the conferences");
                Console.WriteLine("\n3. Add regular member");
                Console.WriteLine("0. Exit");
                Console.Write("\nserver#: ");
                choice = Console.ReadLine();
                if (choice == "0")
                    running = false;
                else if (choice == "1")
                {
                    service.AddConference(12, "MyConference");
                }
                else if (choice == "2")
                {
                    Console.WriteLine(service.GetConferences().ConferenceName);
                }
                else if (choice == "3")
                {
                    service.AddRegularMember("2345678765432", "SomeOtherAffiliation", "https://someotherwebsite.ro", "TestNamee", "TestNamee", "someotheremail@something.com", "someotheruser", "someotherpasswd");
                }
            }
            Console.WriteLine("[SERVER] Shuting down...");
        }
    }
}
