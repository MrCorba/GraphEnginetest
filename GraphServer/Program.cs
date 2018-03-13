using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trinity;

namespace GraphServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrinityConfig.CurrentRunningMode = RunningMode.Embedded;
            TrinityConfig.HttpPort = 3000;
            
            WordsStore server = new WordsStore();
                        
            server.Start();
        }
    }

}